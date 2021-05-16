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
