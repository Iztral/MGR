﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public DbSet<User> Members { get; set; }

        public DbSet<ScenarioGradesTemplates> ScenarioGradesTemplates { get; set; }
    }
}