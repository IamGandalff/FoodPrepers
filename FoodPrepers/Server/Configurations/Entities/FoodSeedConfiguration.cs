using FoodPrepers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    Id = 1,
                    Name = "Chicken breast",
                    Category = "Meat",
                    Description = "Lean protein source",
                    ServingSize = 100,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "SeedData",
                    UpdatedBy = "SeedData"
                },
                new Food
                {
                    Id = 2,
                    Name = "Salmon",
                    Category = "Fish",
                    Description = "Omega-3 fatty acid rich food",
                    ServingSize = 100,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "SeedData",
                    UpdatedBy = "SeedData"
                },
                new Food
                {
                    Id = 3,
                    Name = "Eggs",
                    Category = "Dairy",
                    Description = "High in protein and versatile ingredient",
                    ServingSize = 50,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "SeedData",
                    UpdatedBy = "SeedData"
                },
                new Food
                {
                    Id = 4,
                    Name = "Brown Rice",
                    Category = "Grains",
                    Description = "Whole grain rich in fiber and carbohydrates",
                    ServingSize = 150,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "SeedData",
                    UpdatedBy = "SeedData"
                },
                new Food
                {
                    Id = 5,
                    Name = "Spinach",
                    Category = "Vegetables",
                    Description = "Leafy green vegetable high in nutrients",
                    ServingSize = 50,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "SeedData",
                    UpdatedBy = "SeedData"
                }
            );
        }
    }
}