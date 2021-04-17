using Microsoft.EntityFrameworkCore;
using SEval4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Data
{
    //public class SurveyContext : DbContext
    //{
    //    public static readonly string RowVersion = nameof(RowVersion);

    //    public static readonly string SurveyDb = nameof(SurveyDb).ToLower();

    //    public SurveyContext(DbContextOptions<SurveyContext> options)
    //        : base(options)
    //    {
    //        Debug.WriteLine($"{ContextId} context created.");
    //        Database.EnsureCreated();
    //    }

    //    public DbSet<ExperienceYear> ExperienceYears { get; set; }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<ExperienceYear>()
    //            .Property<byte[]>(RowVersion)
    //            .IsRowVersion();

    //        base.OnModelCreating(modelBuilder);
    //    }

    //    public override void Dispose()
    //    {
    //        Debug.WriteLine($"{ContextId} context disposed.");
    //        base.Dispose();
    //    }

    //    public override ValueTask DisposeAsync()
    //    {
    //        Debug.WriteLine($"{ContextId} context disposed async.")
    //        return base.DisposeAsync();
    //    }
    //}
    public class SurveyContext : DbContext
    {
        public DbSet<ExperienceOption> ExperienceOption { get; set; }

        public SurveyContext(DbContextOptions<SurveyContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExperienceOption>().HasData(GetExperienceOptions());
            base.OnModelCreating(modelBuilder);
        }

        private List<ExperienceOption> GetExperienceOptions() =>
            new List<ExperienceOption>
            {
                new ExperienceOption {
                    Text = "18 - 24",
                    Value = "1",
                    },
                new ExperienceOption {
                    Text = "25 - 34",
                    Value = "2",
                    },
                new ExperienceOption {
                    Text = "35 - 44",
                    Value = "3",
                    },
                new ExperienceOption {
                    Text = "45 - 54",
                    Value = "4",
                    },
                new ExperienceOption {
                    Text = "55 - 64",
                    Value = "5",
                    },
                new ExperienceOption {
                    Text = "65 +",
                    Value = "6",
                    },
            };
        }
    }
