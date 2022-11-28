using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACarApp.Data.Entities;

namespace RentACarApp.Data.Configurations
{
    internal class EngineConfiguration : IEntityTypeConfiguration<Engine>
    {
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            builder.HasData(CreateEngines());
        }

        private List<Engine> CreateEngines()
        {
            List<Engine> engines = new List<Engine>()
            {
                new Engine()
                {
                    Id = 1,
                    Name = "Diesel"
                },

                new Engine()
                {
                    Id = 2,
                    Name = "Petrol"
                },

                new Engine()
                {
                    Id = 3,
                    Name = "Electric"
                }

            };

            return engines;
        }
        
    }
}
