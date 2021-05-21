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

        public async Task<Participant> GetParticipantAsync(Guid userId)
        {
            return await _context.Participants
                .FirstOrDefaultAsync(p => p.Id == userId);
        }

        public async Task<int> UpdateParticipantAsync(Participant participant)
        {
            _context.Participants.Update(participant);
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Allocate user to the study group with lowest number of finished surveys
        /// </summary>
        /// <param name="userId">Unique user identifier</param>
        /// <returns>ID of the allocated group</returns>
        public async Task<int> AllocateParticipantAsync(Guid userId)
        {
            // Count number of allocations that already concluded the experiment
            Dictionary<int, int> groupCounts =
                _context.Participants
                .Where(p => p.IsFinished)
                .GroupBy(p => p.StudyGroup)
                .ToDictionary(pg => pg.Key.Id, pg => pg.Count());

            // Get ID of the group with lowest count value
            int groupId = groupCounts
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

        public async Task<int> GetUserAllocationGroupAsync(Guid userId)
        {
            Participant participant = await _context.Participants
                .FirstOrDefaultAsync(p => p.Id == userId);
            return participant?.StudyGroupId ?? -1;
        }

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

        public async Task<int> InsertNewParticipantAsync(ParticipantSurvey survey)
        {
            await _context.ParticipantSurveys.AddAsync(survey);
            return await _context.SaveChangesAsync();
        }

        #endregion

        #endregion

        #region Baseline Survey

        public async Task<List<Scenario>> GetBaselineScenariosAsync(bool isRandomOrder = false)
        {
            // Select in random order or by ScenarioId (pre-defined order)
            var orderedScenarios = isRandomOrder
                ? _context.Scenarios
                    .OrderBy(s => Guid.NewGuid())
                : _context.Scenarios
                    .OrderBy(s => s.ScenarioId);

            return await orderedScenarios
                .ToListAsync();
        }

        public async Task<List<Response>> GetBaselineResponsesAsync(bool isRandomOrder = false)
        {
            // Select in random order or by ScenarioId (pre-defined order)
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


        #region For development

        public async Task<List<ParticipantSurvey>> GetParticipantSurveysAsync()
        {
            return await _context.ParticipantSurveys
                .ToListAsync();
        }

        #endregion
    }
}
