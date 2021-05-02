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
        public SEvalDBContext(DbContextOptions<SEvalDBContext> options)
            : base(options)
        {
            // Apply any pending migrations
#if DEBUG
            Database.EnsureDeleted();
            Database.EnsureCreated();
#else
            Database.Migrate();
#endif
            Debug.WriteLine($"Context created: {ContextId}.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgeGroup>().HasData(SeedSurvey.AgeGroupsSeed);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AgeGroup> AgeGroup { get; set; }
    }
}
