using Microsoft.EntityFrameworkCore;
using SEval4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Data
{
    public class SEvalDBContext : DbContext
    {

        #region Database sets

        #region Participant data

        public DbSet<Participant> Participants { get; set; }

        #endregion

        #region Study groups

        public DbSet<StudyGroup> StudyGroups { get; set; }

        #endregion

        #region Dropdown options

        public DbSet<AgeGroup> AgeGroup { get; set; }

        public DbSet<YearGroup> YearGroups { get; set; }

        public DbSet<EducationGroup> EducationGroups { get; set; }

        public DbSet<ConfidenceGroup> ConfidenceGroups { get; set; }

        #endregion

        #region Scenarios and responses

        public DbSet<Scenario> Scenarios { get; set; }

        public DbSet<Response> Responses { get; set; }

        public DbSet<EvalScenario> EvaluationScenarios { get; set; }

        public DbSet<EvalResponse> EvaluationResponses { get; set; }

        #endregion

        #region Submited forms

        public DbSet<ParticipantSurvey> ParticipantSurveys { get; set; }

        public DbSet<AnswerBaseline> AnswersBaseline { get; set; }

        #endregion

        #endregion

        #region Public methods

        public SEvalDBContext(DbContextOptions<SEvalDBContext> options)
            : base(options)
        {
            // Apply any pending migrations
            Database.Migrate();

            Debug.WriteLine($"Context created: {ContextId}.");
        }

        #endregion

        #region Protected methods


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Personal survey options
            SetupTextValueEntity(modelBuilder, SeedSurvey.AgeGroupsSeed);
            SetupTextValueEntity(modelBuilder, SeedSurvey.YearGroupsSeed);
            SetupTextValueEntity(modelBuilder, SeedSurvey.EducationGroupsSeed);
            SetupTextValueEntity(modelBuilder, SeedSurvey.ConfidenceGroupsSeed);

            modelBuilder.Entity<StudyGroup>()
                .HasData(SeedSurvey.StudyGroupsSeed);

            // Baseline and postgame scenarios
            SetupScenarios(modelBuilder,       SeedSurvey.ScenariosSeed);
            SetupTextValueEntity(modelBuilder, SeedSurvey.ResponsesSeed);

            // Evaluation scenarios
            SetupScenarios(modelBuilder,       SeedSurvey.EvalScenariosSeed);
            SetupTextValueEntity(modelBuilder, SeedSurvey.EvalResponsesSeed);

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region Private methods

        private void SetupScenarios<T>(
            ModelBuilder modelBuilder, T[] seedData)
            where T : Scenario
        {
            var entity = modelBuilder.Entity<T>();

            entity.HasKey(e => e.Id);
            entity.HasData(seedData);
        }

        private void SetupTextValueEntity<T>(
            ModelBuilder modelBuilder, T[] seedData)
            where T : BaseTextValuePair<int>
        {
            var entity = modelBuilder.Entity<T>();

            entity.HasKey(e => e.Id);
            entity.HasData(seedData);
        }

        #endregion
    }
}
