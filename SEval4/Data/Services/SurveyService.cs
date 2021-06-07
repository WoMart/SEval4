using Microsoft.EntityFrameworkCore;
using SEval4.Data;
using SEval4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEval4.Data.Services
{
    public class SurveyService
    {
        private readonly SEvalDBContext _context;

        public SurveyService(SEvalDBContext context)
        {
            _context = context;
        }

        #region Participant

        #region CRUD

        /// <summary>
        /// Insert
        /// </summary>
        /// <returns>Guid ID of inserted row</returns>
        public async Task<Guid> CreateNewParticipantWithGuidAsync()
        {
            // Create a new participant entry
            Participant participant = new()
            {
                Id = Guid.NewGuid(),
                IsFinished = false,
                CreationTime = DateTime.Now,
            };

            // Insert
            _context.Participants.Add(participant);
            await _context.SaveChangesAsync();

            // Return participant's Guid ID
            return participant.Id;
        }
        /// <summary>
        /// Select
        /// </summary>
        /// <param name="userId">Guid ID of the row</param>
        /// <returns>Participant with given ID or null</returns>
        public async Task<Participant> GetParticipantAsync(Guid userId)
        {
            return await _context.Participants
                .FirstOrDefaultAsync(p => p.Id == userId);
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="participant">Participant object with updated data</param>
        /// <returns>False if given participant does not exist. True otherwise</returns>
        public async Task<bool> UpdateParticipantAsync(Participant participant)
        {
            bool participantExists = _context.Participants
                .Contains(participant);
            
            if (participantExists)
            {
                _context.Participants.Update(participant);
                await _context.SaveChangesAsync();
            }

            return participantExists;
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="participant">Participant to delete</param>
        /// <returns>False if given participant does not exist. True otheriwse.</returns>
        public async Task<bool> DeleteParticipantAsync(Participant participant)
        {
            // Check if the participant exists in the database
            bool participantExists = _context.Participants
                .Contains(participant);

            if (participantExists)
            {
                _context.Remove(participant);
                await _context.SaveChangesAsync();
            }

            // Notify that nothing has been deleted
            return participantExists;
        }

        #endregion

        #region Study group

        public async Task<Guid?> GetStudyGroupIdentifierAsync(int? rowId)
        {
            return (await _context.StudyGroups
                .FirstOrDefaultAsync(sg => sg.Id == rowId.GetValueOrDefault()))
                ?.Identifier;
        }

        public async Task<string> GetStudyGroupName(int? rowId)
        {
            StudyGroup studyGroup = await _context.StudyGroups
                .FirstOrDefaultAsync(sg => sg.Id == rowId);

            return studyGroup?.Name ?? "NULL";
        }

        /// <summary>
        /// Allocate user to the study group with lowest number of finished surveys
        /// </summary>
        /// <param name="userId">Unique user identifier</param>
        /// <returns>ID of the allocated group</returns>
        public async Task<Guid> AllocateParticipantAsync(Guid userId)
        {
            Guid? checkStudyGroupId = await GetUserAllocationGroupAsync(userId);
            if (checkStudyGroupId != null)
            {
                // TODO: Something else
                throw new Exception("Oh no you were allocated already!");
            }

            Dictionary<int, int> allocationCounts = _context.StudyGroups
                .ToDictionary(key => key.Id, value => 0);

            // Count number of allocations that already concluded the experiment
            var studyGroupsGroupedById =
                _context.Participants
                .Where(p => p.IsFinished && p.StudyGroupId.HasValue)
                .ToList()
                .GroupBy(p => p.StudyGroupId);

            foreach (var studyGroup in studyGroupsGroupedById)
            {
                allocationCounts[studyGroup.Key.Value] = studyGroup.Count();
            }

            // Get ID of the group with lowest count value
            int groupId = allocationCounts
                .OrderBy(gc => gc.Value)
                .First()
                .Key;

            // Update participant with the allocated group and timestamp
            Participant participant = await GetParticipantAsync(userId);
            participant.StudyGroupId = groupId;
            participant.AllocationTime = DateTime.Now;

            await UpdateParticipantAsync(participant);

            return (await GetStudyGroupIdentifierAsync(groupId))
                ?? throw new Exception("Service somehow allocated the participant to a nonexistent group.");
        }

        public async Task<Guid?> GetUserAllocationGroupAsync(Guid userId)
        {
            Participant participant = await _context.Participants
                .FirstOrDefaultAsync(p => p.Id == userId);
            return await GetStudyGroupIdentifierAsync(
                participant.StudyGroupId);
        }

        public async Task<List<StudyGroup>> GetStudyGroupsAsync()
        {
            return await _context.StudyGroups
                .ToListAsync();
        }

        #endregion

        #region Progression

        public async Task<bool> UpdateParticipantSurveyUpdateCompetionTime(Guid userId, DateTime? time = null)
        {
            Participant participant = await GetParticipantAsync(userId);

            if (participant != null)
            {
                participant.ParticipantSurveyCompletionTime = time ?? DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return participant != null;
        }

        public async Task<bool> UpdateBaselineSurveyUpdateCompetionTime(Guid userId, DateTime? time = null)
        {
            Participant participant = await GetParticipantAsync(userId);

            if (participant != null)
            {
                participant.BaselineSurveyCompletionTime = time ?? DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return participant != null;
        }

        public async Task<bool> UpdateEvaluationUpdateCompetionTime(Guid userId, DateTime? time = null)
        {
            Participant participant = await GetParticipantAsync(userId);

            if (participant != null)
            {
                participant.EvaluationCompletionTime = time ?? DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return participant != null;
        }

        public async Task<bool> UpdatePostgameSurveyUpdateCompetionTime(Guid userId, DateTime? time = null)
        {
            Participant participant = await GetParticipantAsync(userId);

            if (participant != null)
            {
                participant.PostgameSurveyCompletionTime = time ?? DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return participant != null;
        }

        public async Task<bool> UpdateFeedbackUpdateCompetionTime(Guid userId, DateTime? time = null)
        {
            Participant participant = await GetParticipantAsync(userId);

            if (participant != null)
            {
                participant.FeedbackCompletionTime = time ?? DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return participant != null;
        }

        #endregion

        #region IsFinished

        public async Task RecordParticipantFinishedStudy(Guid userId, bool isFinished = true)
        {
            Participant participant = _context.Participants
                .First(p => p.Id == userId);

            participant.IsFinished = isFinished;

            await UpdateParticipantAsync(participant);
        }

        #endregion

        #endregion

        #region Participant survey

        #region Dropdown options

        public async Task<List<AgeGroup>> GetAgeGroupsAsync()
        {
            return await _context.AgeGroup
                .OrderBy(g => g.Id)
                .ToListAsync();
        }

        public async Task<List<YearGroup>> GetYearGroupsAsync()
        {
            return await _context.YearGroups
                .OrderBy(g => g.Id)
                .ToListAsync();
        }

        public async Task<List<EducationGroup>> GetEducationGroupsAsync()
        {
            return await _context.EducationGroups
                .OrderBy(g => g.Id)
                .ToListAsync();
        }

        public async Task<List<ConfidenceGroup>> GetConfidenceGroupsAsync()
        {
            return await _context.ConfidenceGroups
                .OrderBy(g => g.Id)
                .ToListAsync();
        }

        #endregion

        #region Submit

        public async Task<int> InsertNewParticipantSurveyAsync(ParticipantSurvey survey)
        {
            await _context.ParticipantSurveys.AddAsync(survey);
            int rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected > 0)
            {
                await UpdateParticipantSurveyUpdateCompetionTime(survey.UserId);
            }
            return rowsAffected;
        }

        #endregion

        #endregion

        #region Scenario Surveys

        public async Task<List<Scenario>> GetScenariosAsync(Guid userId, bool isRandomOrder = false)
        {
            // Get list of scenarios participant has seen
            List<int> seenScenarios = await _context.SurveyAnswers
                .Where(sa => sa.UserId == userId)
                .Select(sa => sa.ScenarioId)
                .ToListAsync();
            
            // Get Scenarios participant has not seen yet
            IQueryable<Scenario> scenarios = _context.Scenarios
                    .Where(s => !seenScenarios.Contains(s.Id));

            // Select in random order or by ScenarioId
            IOrderedQueryable<Scenario> orderedScenarios = isRandomOrder
                ? scenarios.OrderBy(s => Guid.NewGuid())
                : scenarios.OrderBy(s => s.Id);

            int allScenariosCount = await _context.Scenarios
                .CountAsync();

            // Return the half of all scenarios
            return await orderedScenarios
                .Take(allScenariosCount / 2)
                .ToListAsync();
        }

        public async Task<List<Response>> GetResponsesAsync(bool isRandomOrder = false)
        {
            // Select in random order or by pre-defined order
            IOrderedQueryable<Response> orderedResponses = isRandomOrder
                ? _context.Responses.OrderBy(s => Guid.NewGuid())
                : _context.Responses.OrderBy(s => s.Value);

            return await orderedResponses.ToListAsync();
        }

        public async Task<int> SubmitSurveyAnswersAsync(List<SurveyAnswer> answers, string surveyName)
        {
            // Mark the correct answers for easier data analysis
            foreach (SurveyAnswer answer in answers)
            {
                answer.SurveyName = surveyName;
                answer.CreateTime = DateTime.Now;
                answer.IsCorrect = _context.Responses
                    .FirstOrDefault(r =>
                    r.ScenarioId == answer.ScenarioId
                    && r.Id == answer.ResponseId)
                    ?.IsCorrect ?? false;
            }

            // Do some validaiton? Number of elements, Guid is the same and non-empty, etc.
            _context.SurveyAnswers.AddRange(answers);
            int rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected > 0)
            {
                if (surveyName == "Baseline")
                {
                    await UpdateBaselineSurveyUpdateCompetionTime(answers[0].UserId);
                }
                else if (surveyName == "Postgame")
                {
                    await UpdatePostgameSurveyUpdateCompetionTime(answers[0].UserId);
                }
            }
            return rowsAffected;
        }

        #endregion

        #region Evaluation

        public async Task<List<EvalScenario>> GetEvaluationRoundsAsync(bool isRandomOrder = false)
        {
            // Select in random order or by Id
            IOrderedQueryable<EvalScenario> scenarios = isRandomOrder
                ? _context.EvaluationScenarios.OrderBy(es => Guid.NewGuid())
                : _context.EvaluationScenarios.OrderBy(es => es.Id);

            // Build a list of EvaluationRounds and return
            return await scenarios
                .ToListAsync();
        }

        public async Task<List<EvalResponse>> GetEvaluationResponsesAsync(bool isRandomOrder = false)
        {
            // Select in random order or by pre-defined order
            IOrderedQueryable<EvalResponse> orderedResponses = isRandomOrder
                ? _context.EvaluationResponses.OrderBy(s => Guid.NewGuid())
                : _context.EvaluationResponses.OrderBy(s => s.Value);

            return await orderedResponses.ToListAsync();
        }

        public async Task<int> InsertEvaluationAnswerAsync(EvalAnswer answer)
        {
            _context.EvaluationAnswers.Add(answer);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> SumAndRecordAttemptsPerScenarioAsync(Guid userId)
        {
            List<AttemptCount> attemptCounts = _context.EvaluationAnswers
                .Where(a => a.UserId == userId)
                .GroupBy(a => a.ScenarioId)
                .Select(group => new AttemptCount
                {
                    UserId = userId,
                    ScenarioId = group.Key,
                    Attempts = group.Count(),
                })
                .ToList();

            _context.AttemptCounts.AddRange(attemptCounts);
            int rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected > 0)
            {
                await UpdateEvaluationUpdateCompetionTime(userId);
            }
            return rowsAffected;
        }

        public async Task<List<AttemptCount>> GetAttemptCountAsync(Guid userId)
        {
            return await _context.AttemptCounts
                .Where(ac => ac.UserId == userId)
                .OrderBy(ac => ac.ScenarioId)
                .ToListAsync();
        }


        #endregion

        #region Participant Feedback

        #region Dropdown options

        public async Task<List<StudyHelpfulness>> GetStudyHelpfulnessAsync()
        {
            return await _context.StudyHelpfulness
                .OrderBy(sh => sh.Id)
                .ToListAsync();
        }

        public async Task<List<ConfidenceChange>> GetConfidenceChangeAsync()
        {
            return await _context.ConfidenceChange
                .OrderBy(sh => sh.Id)
                .ToListAsync();
        }

        #endregion

        public async Task<int> SubmitParticipantFeedbackAsync(ParticipantFeedback feedback)
        {
            // Trim the textareas
            feedback.ScenarioFeedback = feedback.ScenarioFeedback?.Trim();
            feedback.TrainingFeedback = feedback.TrainingFeedback?.Trim();
            feedback.GeneralFeedback  = feedback.GeneralFeedback?.Trim();

            feedback.CreateDate = DateTime.Now;

            _context.ParticipantFeedback.Add(feedback);
            int rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected > 0)
            {
                await UpdateFeedbackUpdateCompetionTime(feedback.UserId);
            }
            return rowsAffected;
        }

        #endregion

        #region Get CSV data

        public async Task<string> ParticipantsToCsvAsync()
        {
            var builder = new StringBuilder();

            AddCsvLine(builder, new string[]
            {
                nameof(Participant.Id),
                nameof(Participant.IsFinished),
                nameof(Participant.CreationTime),
                nameof(Participant.StudyGroup),
                nameof(Participant.AllocationTime),
            });

            List<Participant> participants = await _context.Participants
                .ToListAsync();

            foreach (Participant participant in participants)
            {
                AddCsvLine(builder, new string[]
                    {
                        participant.Id.ToString(),
                        participant.IsFinished ? "1" : "0",
                        participant.CreationTime.ToString(),
                        await GetStudyGroupName(participant.StudyGroupId),
                        GetValueStringOrNullText(participant.AllocationTime),
                    });
            }

            return builder.ToString();
        }

        public async Task<string> ParticipantSurveysToCsvAsync()
        {
            var builder = new StringBuilder();

            AddCsvLine(builder, new string[]
            {
                nameof(ParticipantSurvey.Id),
                nameof(ParticipantSurvey.UserId),
                nameof(ParticipantSurvey.AgeGroup),
                nameof(ParticipantSurvey.EducationGroup),
                nameof(ParticipantSurvey.ProfessionalExperience),
                nameof(ParticipantSurvey.HasFormalTraining),
                nameof(ParticipantSurvey.HasInformalTraining),
                nameof(ParticipantSurvey.PhishingConfidence),
                nameof(ParticipantSurvey.SpearPhishingConfidence),
            });

            List<ParticipantSurvey> surveys = await _context.ParticipantSurveys
                .ToListAsync();

            foreach (ParticipantSurvey survey in surveys)
            {
                AddCsvLine(builder, new string[]
                    {
                        survey.Id.ToString(),
                        survey.UserId.ToString(),
                        survey.AgeGroup,
                        survey.EducationGroup,
                        survey.ProfessionalExperience,
                        survey.HasFormalTraining,
                        survey.HasInformalTraining,
                        survey.PhishingConfidence,
                        survey.SpearPhishingConfidence,
                    });
            }

            return builder.ToString();
        }

        public async Task<string> SurveyAnswersToCsvAsync()
        {
            var builder = new StringBuilder();

            AddCsvLine(builder, new string[]
            {
                nameof(SurveyAnswer.Id),
                nameof(SurveyAnswer.CreateTime),
                nameof(SurveyAnswer.UserId),
                nameof(SurveyAnswer.SurveyName),
                nameof(SurveyAnswer.ScenarioId),
                nameof(SurveyAnswer.ResponseId),
                nameof(SurveyAnswer.IsCorrect),
            });

            List<SurveyAnswer> evalAnswers = await _context.SurveyAnswers
                .OrderBy(ac => ac.UserId)
                .ThenBy(ac => ac.SurveyName)
                .ThenBy(ac => ac.ScenarioId)
                .ToListAsync();

            foreach (SurveyAnswer evalAnswer in evalAnswers)
            {
                string responseDescription = _context.Responses
                    .First(r => r.Id == evalAnswer.ResponseId)
                    .Description;

                AddCsvLine(builder, new string[]
                    {
                        evalAnswer.Id.ToString(),
                        evalAnswer.CreateTime.ToString(),
                        evalAnswer.UserId.ToString(),
                        evalAnswer.SurveyName,
                        evalAnswer.ScenarioId.ToString(),
                        responseDescription,
                        evalAnswer.IsCorrect ? "1" : "0",
                    });
            }

            return builder.ToString();
        }

        public async Task<string> EvaluationAnswersToCsvAsync()
        {
            var builder = new StringBuilder();

            AddCsvLine(builder, new string[]
            {
                nameof(EvalAnswer.Id),
                nameof(EvalAnswer.CreateTime),
                nameof(EvalAnswer.UserId),
                nameof(EvalAnswer.ScenarioId),
                nameof(EvalAnswer.ResponseId),
                nameof(EvalAnswer.IsCorrect),
            });

            List<EvalAnswer> evalAnswers = await _context.EvaluationAnswers
                .OrderBy(ac => ac.UserId)
                .ThenBy(ac => ac.ScenarioId)
                .ToListAsync();

            foreach (EvalAnswer evalAnswer in evalAnswers)
            {
                string responseText = _context.EvaluationResponses
                    .First(r => r.Id == evalAnswer.ResponseId)
                    .Description;

                AddCsvLine(builder, new string[]
                    {
                        evalAnswer.Id.ToString(),
                        evalAnswer.CreateTime.ToString(),
                        evalAnswer.UserId.ToString(),
                        evalAnswer.ScenarioId.ToString(),
                        responseText,
                        evalAnswer.IsCorrect ? "1" : "0",
                    });
            }

            return builder.ToString();
        }

        public async Task<string> AttemptCountsToCsvAsync()
        {
            var builder = new StringBuilder();

            AddCsvLine(builder, new string[]
            {
                nameof(AttemptCount.Id),
                nameof(AttemptCount.UserId),
                nameof(AttemptCount.ScenarioId),
                nameof(AttemptCount.Attempts),
            });

            List<AttemptCount> attemptCounts = await _context.AttemptCounts
                .OrderBy(ac => ac.Id)
                .ThenBy(ac => ac.ScenarioId)
                .ToListAsync();

            foreach (AttemptCount attemptCount in attemptCounts)
            {
                AddCsvLine(builder, new string[]
                    {
                        attemptCount.Id.ToString(),
                        attemptCount.UserId.ToString(),
                        attemptCount.ScenarioId.ToString(),
                        attemptCount.Attempts.ToString(),
                    });
            }

            return builder.ToString();
        }

        public async Task<string> ParticipantFeedbackToCsvAsync()
        {
            var builder = new StringBuilder();

            AddCsvLine(builder, new string[]
            {
                nameof(ParticipantFeedback.Id),
                nameof(ParticipantFeedback.UserId),
                nameof(ParticipantFeedback.CreateDate),
                nameof(ParticipantFeedback.StudyHelpfulness),
                nameof(ParticipantFeedback.PhishingConfidenceChange),
                nameof(ParticipantFeedback.SpearPhishingConfidenceChange),
                nameof(ParticipantFeedback.ScenarioFeedback),
                nameof(ParticipantFeedback.TrainingFeedback),
                nameof(ParticipantFeedback.GeneralFeedback),
            });

            List<ParticipantFeedback> feedbacks = await _context.ParticipantFeedback
                .ToListAsync();
            foreach (ParticipantFeedback feedback in feedbacks)
            {
                AddCsvLine(builder, new string[]
                    {
                        feedback.Id.ToString(),
                        feedback.UserId.ToString(),
                        feedback.CreateDate.ToString(),
                        feedback.StudyHelpfulness,
                        feedback.PhishingConfidenceChange,
                        feedback.SpearPhishingConfidenceChange,
                        GetValueStringOrNullText(feedback.ScenarioFeedback),
                        GetValueStringOrNullText(feedback.TrainingFeedback),
                        GetValueStringOrNullText(feedback.GeneralFeedback),
                    });
            }

            return builder.ToString();
        }

        #endregion

        #region Private helpers

        private void AddCsvLine(StringBuilder builder, string[] data, string delimeter = "\t")
        {
            builder.AppendLine(string.Join(delimeter, data));
        }
        private string GetValueStringOrNullText(string value)
        {
            return string.IsNullOrWhiteSpace(value)
                ? "NULL"
                : value.ToString();
        }

        private string GetValueStringOrNullText<T>(T? value)
            where T : struct
        {
            return value.HasValue
                ? value.ToString()
                : "NULL";
        }

        #endregion

        #region For development

        public async Task<List<ParticipantSurvey>> GetParticipantSurveysAsync()
        {
            return await _context.ParticipantSurveys
                .ToListAsync();
        }

        #endregion
    }
}