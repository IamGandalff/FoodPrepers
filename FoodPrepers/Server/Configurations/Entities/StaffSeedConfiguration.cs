using FoodPrepers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "johndoe@example.com",
                    UserName = "johndoe",
                    Password = "secret"
                },
                new Staff
                {
                    Id = 2,
                    Name = "Jane Doe",
                    Email = "janedoe@example.com",
                    UserName = "janedoe",
                    Password = "secret"
                }
            );
        }
    }
}