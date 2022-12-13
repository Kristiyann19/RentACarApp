﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACarApp.Data.Entities;

namespace RentACarApp.Data.Configurations
{
    internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasData(new Agent()
            {
                Id = 1,
                PhoneNumber = "+359888888888",
                FirstName = "Agent",
                LastName = "Agentov",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            });
        }
    }
}
