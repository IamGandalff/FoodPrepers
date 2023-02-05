using FoodPrepers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Server.Configurations.Entities
{
    public class MealPlanSeedConfiguration : IEntityTypeConfiguration<MealPlan>
    {
        public void Configure(EntityTypeBuilder<MealPlan> builder)
        {
            builder.HasData(
                new MealPlan
                {
                    Id = 1,
                    UserId = 1,
                    Name = "High Protein Meal Plan",
                    Description = "A meal plan high in protein",
                    TotalCaloricIntake = 2500,
                    TotalProtein = 200,
                    TotalCarbohydrates = 300,
                    TotalFat = 100,
                    TotalSodium = 1500,
                    TotalFiber = 25,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "SeedData",
                    UpdatedBy = "SeedData"
                },
                new MealPlan
                {
                    Id = 2,
                    UserId = 1,
                    Name = "Low Carb Meal Plan",
                    Description = "A meal plan low in carbohydrates",
                    TotalCaloricIntake = 2000,
                    TotalProtein = 150,
                    TotalCarbohydrates = 200,
                    TotalFat = 80,
                    TotalSodium = 1000,
                    TotalFiber = 20,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "SeedData",
                    UpdatedBy = "SeedData"
                });
        }
    }
}



