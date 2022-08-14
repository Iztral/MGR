using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SWO.Shared.Models;

namespace SWO.Portal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<GradeTemplate> GradeTemplates { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Scenario> Scenarios { get; set; }

        public DbSet<Sensor> Sensors { get; set; }

        public DbSet<SensorValue> SensorValues { get; set; }

        public DbSet<Simulation> Simulations { get; set; }

        public DbSet<Simulator> Simulators { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<ScenarioGradesTemplates> ScenarioGradesTemplates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Member>().HasMany(u => u.Simulations);
            builder.Entity<Simulation>().HasOne(u => u.Instructor);
            builder.Entity<Simulation>().HasOne(u => u.Trainee);
        }
    }
}