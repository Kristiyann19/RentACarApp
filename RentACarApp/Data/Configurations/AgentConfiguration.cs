using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACarApp.Data.Entities;

namespace RentACarApp.Data.Configurations
{
    internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {

            builder.HasData(CreateUsers());

        }

        private List<Agent> CreateUsers()
        {
            var agents = new List<Agent>();
 

            var agent = new Agent()
            {
                Id = 1,
                PhoneNumber = "+359888888888",
                FirstName = "Agent",
                LastName = "Agentov",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };

            agents.Add(agent);

            agent = new Agent()
            {
                Id = 5,
                PhoneNumber = "+359123456789",
                FirstName = "admin@mail.com",
                LastName = "admin@mail.com",
                UserId = "78551b5d - fd8d - 4711 - 83b5 - ed39ae47c072"
            };

            agents.Add(agent);
            return agents;

        }
    }
}
