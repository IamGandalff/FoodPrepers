using FoodPrepers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Server.Configurations.Entities
{
    public class NutritionFactSeedConfiguration : IEntityTypeConfiguration<NutritionFact>
    {
        public void Configure(EntityTypeBuilder<NutritionFact> builder)
        {
            builder.HasData(
                new NutritionFact
                {
                    Id = 1,
                    FoodId = 1,
                    ServingSize = 100,
                    CaloricValue = 165,
                    TotalFat = (int)3.6f,
                    SaturatedFat = (int)1.3f,
                    TransFat = (int)0f,
                    Cholesterol = (int)72f,
                    Sodium = (int)74f,
                    TotalCarbohydrates = (int)0f,
                    DietaryFiber = (int)0f,
                    Sugars = (int)0f,
                    Protein = (int)31f
                },
                new NutritionFact
                {
                    Id = 2,
                    FoodId = 2,
                    ServingSize = 100,
                    CaloricValue = 208,
                    TotalFat = (int)13.6f,
                    SaturatedFat = (int)2f,
                    TransFat = (int)0f,
                    Cholesterol = (int)55f,
                    Sodium = (int)63f,
                    TotalCarbohydrates = (int)0f,
                    DietaryFiber = (int)0f,
                    Sugars = (int)0f,
                    Protein = (int)22f
                }
            );
        }
    }
}