using FoodPrepers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Server.Configurations.Entities
{
    public class MealSeedConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new Meal
                {
                    Id = 1,
                    MealPlanId = 1,
                    Name = "Breakfast",
                    Description = "A meal to start your day",
                    TotalCaloricIntake = 500,
                    TotalProtein = 25,
                    TotalCarbohydrates = 50,
                    TotalFat = 20,
                    TotalSodium = 200,
                    TotalFiber = 10,
                    DateCreated = DateTime.Now,
                    CreatedBy = "SeedData",
                },
                new Meal
                {
                    Id = 2,
                    MealPlanId = 1,
                    Name = "Lunch",
                    Description = "A meal to have in the middle of your day",
                    TotalCaloricIntake = 600,
                    TotalProtein = 30,
                    TotalCarbohydrates = 55,
                    TotalFat = 25,
                    TotalSodium = 250,
                    TotalFiber = 15,
                    DateCreated = DateTime.Now,
                    CreatedBy = "SeedData",
                },
                new Meal
                {
                    Id = 3,
                    MealPlanId = 1,
                    Name = "Dinner",
                    Description = "A meal to have at the end of your day",
                    TotalCaloricIntake = 700,
                    TotalProtein = 35,
                    TotalCarbohydrates = 60,
                    TotalFat = 30,
                    TotalSodium = 300,
                    TotalFiber = 20,
                    DateCreated = DateTime.Now,
                    CreatedBy = "SeedData",
                }
            );
        }
    }
}