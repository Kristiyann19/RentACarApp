using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACarApp.Data.Entities;

namespace RentACarApp.Data.Configurations
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(CreateCar());
        }

        private List<Car> CreateCar()
        {

            var cars = new List<Car>()
            {
                new Car
                {
                    Id = 1,
                    Make = "BMW",
                    Model = "440",
                    Year = 2017,
                    Price = 300,
                    Color = "White Metallic",
                    HorsePower = 358,
                    ImageUrl = "https://media.carsandbids.com/cdn-cgi/image/width=1800,quality=70/438ad923cef6d8239e95d61e7d6849486bae11d9/photos/KDgVJ2G8.NfXWiaxfK-(edit).jpg?t=164667913335",
                    TypeCarId = 6,
                    EngineId = 2
                },

                new Car
                {
                    Id = 2,
                    Make = "Mercedes-Benz",
                    Model = "C63 AMG S",
                    Year = 2015,
                    Price = 400,
                    Color = "White Metallic",
                    HorsePower = 510,
                    ImageUrl = "https://carsguide-res.cloudinary.com/image/upload/f_auto,fl_lossy,q_auto,t_cg_hero_large/v1/editorial/mercedes-benz-c63s-amg-2015-australia-%285%29.jpg",
                    TypeCarId = 4,
                    EngineId = 2
                },

                new Car
                {
                    Id = 3,
                    Make = "Tesla",
                    Model = "Model S",
                    Year = 2017,
                    Price = 300,
                    Color = "Red Metallic",
                    HorsePower = 420,
                    ImageUrl = "https://thedriven.io/wp-content/uploads/2019/09/car-sales-model-s-2017.jpg",
                    TypeCarId = 4,
                    EngineId = 3
                }

            };

            return cars;
        }      
    }
}
