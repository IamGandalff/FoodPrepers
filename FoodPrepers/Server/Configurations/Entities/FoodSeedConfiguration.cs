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
                }
            );
        }
    }
}