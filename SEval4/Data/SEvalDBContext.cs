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

        #region Dropdown options

        public DbSet<AgeGroup> AgeGroup { get; set; }

        public DbSet<YearGroup> YearGroups { get; set; }

        public DbSet<EducationGroup> EducationGroups { get; set; }

        public DbSet<ConfidenceGroup> ConfidenceGroups { get; set; }

        #endregion

        #region Survey scenarios

        public DbSet<Scenario> Scenarios { get; set; }

        public DbSet<Response> Responses { get; set; }

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
            // Seed website data
            SetupTextValueEntity(modelBuilder, SeedSurvey.AgeGroupsSeed);
            SetupTextValueEntity(modelBuilder, SeedSurvey.YearGroupsSeed);
            SetupTextValueEntity(modelBuilder, SeedSurvey.EducationGroupsSeed);
            SetupTextValueEntity(modelBuilder, SeedSurvey.ConfidenceGroupsSeed);

            SetupScenarios(modelBuilder);
            SetupTextValueEntity(modelBuilder, SeedSurvey.ResponsesSeed);

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region Private methods

        private void SetupScenarios(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Scenario>();

            entity.HasKey(e => e.Id);
            entity.HasData(SeedSurvey.ScenariosSeed);
        }

        private void SetupTextValueEntity<T>(
            ModelBuilder modelBuilder, T[] seedData)
            where T : BaseTextValuePair<int>
        {
            var entity = modelBuilder.Entity<T>();

            //// Set up row versioning for concurrency (unnecessary tbf)
            //entity.Property<byte[]>(RowVersion)
            //    .IsRowVersion();

            // The HasKey is technically not necessary, since EF recognises "*id*" properties as PK
            entity.HasKey(e => e.Id);

            // Seed values
            entity.HasData(seedData);
        }

        #endregion
    }
}
