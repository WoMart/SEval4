using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        #region Database name

        //public static readonly string RowVersion = nameof(RowVersion);

        public static readonly string SurveyDb = nameof(SurveyDb).ToLower();

        #endregion

        #region Database sets

        public DbSet<AgeGroup> AgeGroups { get; private set; }

        public DbSet<YearGroup> YearGroups { get; private set; }

        public DbSet<EducationGroup> EducationGroups { get; private set; }

        public DbSet<ConfidenceGroup> ConfidenceGroups { get; private set; }

        public DbSet<ParticipantSurvey> ParticipantSurveys { get; set; }

        public DbSet<Scenario> Scenarios { get; set; }

        public DbSet<ScenarioResponse> ScenarioResponses { get; set; }

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

            FetchScenariosFromJson(modelBuilder);
            //modelBuilder.Entity<ParticipantSurvey>()
            //    .Property(RowVersion)
            //    .IsRowVersion();

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region Private methods

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

        private void SetupTextValueEntityFromJson<T>(
            ModelBuilder modelBuilder)
            where T: BaseTextValuePair<int>
        {

        }

        private void FetchScenariosFromJson(ModelBuilder modelBuilder)
        {
            string path = @"Data\Json\Scenarios.json";

            using StreamReader sr = new(path);

            string json = sr.ReadToEnd();
            var jsonScenarios = JsonConvert
                .DeserializeObject<List<JsonScenario>>(json);

            // Convert json scenarios to entity framework models
            List<Scenario> scenarios = new();
            foreach (var scene in jsonScenarios)
            {
                Guid scenarioId = Guid.NewGuid();

                // Convert json scenario responses to entity framework models
                List<ScenarioResponse> responses = new();
                foreach (var resp in scene.Responses)
                {
                    responses.Add(new ScenarioResponse
                    {
                        Id         = Guid.NewGuid(),
                        Text       = resp.Text,
                        Value      = resp.Value,
                        Correct    = resp.Correct,
                        Tag        = resp.Tag,
                        ScenarioId = scenarioId,
                    });
                }

                modelBuilder.Entity<ScenarioResponse>().HasData(responses);

                scenarios.Add(new Scenario
                {
                    ScenarioId = scenarioId,
                    Context = scene.Context,
                    Correct = responses.Single(r => r.Correct).Id,
                    //Responses = responses,
                });
            }

            modelBuilder.Entity<Scenario>().HasData(scenarios);
        }

        #endregion

    }
}
