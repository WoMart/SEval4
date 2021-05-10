using Microsoft.EntityFrameworkCore;
using SEval4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Data
{
    public class SurveyContext : DbContext
    {
        #region Database sets

        public DbSet<AgeGroup> AgeGroups { get; private set; }

        public DbSet<YearGroup> YearGroups { get; private set; }

        public DbSet<EducationGroup> EducationGroups { get; private set; }

        public DbSet<ConfidenceGroup> ConfidenceGroups { get; private set; }

        public DbSet<ParticipantSurvey> ParticipantSurveys { get; set; }

        public DbSet<Scenario> Scenarios { get; private set; }

        //public DbSet<ScenarioResponse> ScenarioResponses { get; set; }

        public DbSet<Response> Responses { get; private set; }

        #endregion

        #region Public methods

        public SurveyContext(DbContextOptions<SurveyContext> options)
            : base(options)
        {
            Debug.WriteLine($"{ContextId} context created.");
            Database.EnsureCreated();
        }

        public override void Dispose()
        {
            Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }

        public override ValueTask DisposeAsync()
        {
            Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
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
