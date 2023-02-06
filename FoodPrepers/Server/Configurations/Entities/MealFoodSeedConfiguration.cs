using FoodPrepers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Server.Configurations.Entities
{
    public class MealFoodSeedConfiguration : IEntityTypeConfiguration<MealFood>
    {
        public void Configure(EntityTypeBuilder<MealFood> builder)
        {
            builder.HasData(
                new MealFood
                {
                    Id = 1,
                    MealId = 1,
                    FoodId = 1,
                    ServingSize = 100,
                    TotalCaloricIntake = 200,
                    TotalProtein = 20,
                    TotalFiber = 10,
                },
                new MealFood
                {
                    Id = 2,
                    MealId = 1,
                    FoodId = 2,
                    ServingSize = 100,
                    TotalCaloricIntake = 300,
                    TotalProtein = 25,
                    TotalFiber = 15,
                },
                new MealFood
                {
                    Id = 3,
                    MealId = 2,
                    FoodId = 1,
                    ServingSize = 100,
                    TotalCaloricIntake = 400,
                    TotalProtein = 30,
                    TotalFiber = 20,
                },
                new MealFood
                {
                    Id = 4,
                    MealId = 2,
                    FoodId = 2,
                    ServingSize = 100,
                    TotalCaloricIntake = 500,
                    TotalProtein = 35,
                    TotalFiber = 25,
                },
                new MealFood
                {
                    Id = 5,
                    MealId = 3,
                    FoodId = 1,
                    ServingSize = 100,
                    TotalCaloricIntake = 300,
                    TotalProtein = 25,
                    TotalFiber = 15,
                });
        }
    }
}
