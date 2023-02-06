using FoodPrepers.Server.Configurations.Entities;
using FoodPrepers.Server.Models;
using FoodPrepers.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<NutritionFact> NutritionFacts { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealFood> MealFoods { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString)
                          .EnableSensitiveDataLogging();
        }
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YourDbName;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FoodSeedConfiguration());
            builder.ApplyConfiguration(new NutritionFactSeedConfiguration());
            builder.ApplyConfiguration(new MealPlanSeedConfiguration());
            builder.ApplyConfiguration(new MealSeedConfiguration());
            builder.ApplyConfiguration(new MealFoodSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());

            
        }
    }
}
