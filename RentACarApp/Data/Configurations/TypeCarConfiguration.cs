using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACarApp.Data.Entities;

namespace RentACarApp.Data.Configurations
{
    internal class TypeCarConfiguration : IEntityTypeConfiguration<TypeCar>
    {
        public void Configure(EntityTypeBuilder<TypeCar> builder)
        {
            builder.HasData(CreateTypesCars());
        }

        private List<TypeCar> CreateTypesCars()
        {
            List<TypeCar> typesCars = new List<TypeCar>()
            {
                new TypeCar()
                {
                    Id = 1,
                    Name = "SUV"
                },

                new TypeCar()
                {
                    Id = 2,
                    Name = "Hatchback"
                },

                new TypeCar()
                {
                    Id = 3,
                    Name = "Convertible"
                },

                new TypeCar()
                {
                    Id = 4,
                    Name = "Sedan"
                },

                new TypeCar()
                {
                    Id = 5,
                    Name = "Sports Car"
                },

                new TypeCar()
                {
                    Id = 6,
                    Name = "Coupe"
                },

                new TypeCar()
                {
                    Id = 7,
                    Name = "Pickup Truck"
                }


            };

            return typesCars;
        } 
    }
        
    
}
