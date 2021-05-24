using Microsoft.EntityFrameworkCore;
using SEval4.Data;
using SEval4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        #region Study group allocation

        /// <summary>
        /// Allocate user to the study group with lowest number of finished surveys
        /// </summary>
        /// <param name="userId">Unique user identifier</param>
        /// <returns>ID of the allocated group</returns>
        public async Task<int> AllocateParticipantAsync(Guid userId)
        {
            int? checkStudyGroupId = await GetUserAllocationGroupAsync(userId);
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

            return groupId;
        }

        public async Task<int?> GetUserAllocationGroupAsync(Guid userId)
        {
            Participant participant = await _context.Participants
                .FirstOrDefaultAsync(p => p.Id == userId);
            return participant?.StudyGroupId;
        }

        public async Task<bool> IsTheUserAllocatedGroupAsync(Guid userId, int? studyGroupId)
        {
            if (studyGroupId.HasValue)
            {
                return await _context.Participants
                   .Where(p => 
                   p.Id == userId && 
                   p.StudyGroupId == studyGroupId.Value)
                   .AnyAsync();
            }
            else
            {
                return false;
            }
        }

        #endregion

        #endregion

        #region Participant survey

        #region Dropdown options

        public async Task<List<AgeGroup>> GetAgeGroupsAsync()
        {
            return await _context.AgeGroup
                .OrderBy(g => g.Value)
                .ToListAsync();
        }

        public async Task<List<YearGroup>> GetYearGroupsAsync()
        {
            return await _context.YearGroups
                .OrderBy(g => g.Value)
                .ToListAsync();
        }

        public async Task<List<EducationGroup>> GetEducationGroupsAsync()
        {
            return await _context.EducationGroups
                .OrderBy(g => g.Value)
                .ToListAsync();
        }

        public async Task<List<ConfidenceGroup>> GetConfidenceGroupsAsync()
        {
            return await _context.ConfidenceGroups
                .OrderBy(g => g.Value)
                .ToListAsync();
        }

        #endregion

        #region Submit

        public async Task<int> InsertNewParticipantSurveyAsync(ParticipantSurvey survey)
        {
            await _context.ParticipantSurveys.AddAsync(survey);
            return await _context.SaveChangesAsync();
        }

        #endregion

        #endregion

        #region Baseline Survey

        public async Task<List<Scenario>> GetBaselineScenariosAsync(bool isRandomOrder = false)
        {
            // Select in random order or by ScenarioId
            var orderedScenarios = isRandomOrder
                ? _context.Scenarios.OrderBy(s => Guid.NewGuid())
                : _context.Scenarios.OrderBy(s => s.ScenarioId);

            return await orderedScenarios
                .ToListAsync();
        }

        public async Task<List<Response>> GetBaselineResponsesAsync(bool isRandomOrder = false)
        {
            // Select in random order or by pre-defined order
            var orderedResponses = isRandomOrder
                ? _context.Responses.OrderBy(s => Guid.NewGuid())
                : _context.Responses.OrderBy(s => s.ResponseOrder);

            return await orderedResponses.ToListAsync();
        }

        public async Task<int> SubmitBaselineFormAsync(List<AnswerBaseline> answers)
        {
            // Do some validaiton? Number of elements, Guid is the same and non-empty, etc.
            _context.AnswersBaseline.AddRange(answers);
            return await _context.SaveChangesAsync();
        }

        #endregion

        #region Evaluation

        public async Task<List<EvalScenario>> GetEvaluationRoundsAsync(bool isRandomOrder = false)
        {
            // Select in random order or by Id
            IQueryable<EvalScenario> scenarios = isRandomOrder
                ? _context.EvaluationScenarios.OrderBy(es => Guid.NewGuid())
                : _context.EvaluationScenarios.OrderBy(es => es.Id);

            // Build a list of EvaluationRounds and return
            return await scenarios
                .ToListAsync();
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
