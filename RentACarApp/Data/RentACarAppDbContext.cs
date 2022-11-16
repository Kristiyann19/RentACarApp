using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACarApp.Data.Entities;

namespace RentACarApp.Data
{
    public class RentACarAppDbContext : IdentityDbContext<User>
    {

        public RentACarAppDbContext(DbContextOptions<RentACarAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<TypeCar> Types { get; set; }

        public DbSet<Engine> Engines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UserCars>()
                .HasKey(x => new { x.UserId, x.CarId });


            builder.Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(70)
                .IsRequired();



            builder
                .Entity<Car>()
                .HasData(new Car
                {
                    Id = 1,
                    Make = "BMW",
                    Model = "440",
                    Year = 2017,
                    Price = 32000,
                    Description = "The 2015 BMW 4 Series is now available with Oyster Dakota leather, Brushed Aluminum trim, new 18-inch and 19-inch wheels in the Luxury Line trim. ",
                    ImageUrl = "https://media.carsandbids.com/cdn-cgi/image/width=1800,quality=70/438ad923cef6d8239e95d61e7d6849486bae11d9/photos/KDgVJ2G8.NfXWiaxfK-(edit).jpg?t=164667913335",
                    TypeCarId = 6,
                    EngineId = 2
                });

            builder
                .Entity<TypeCar>()
                .HasData(new TypeCar()
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
                });


            builder
                .Entity<Engine>()
                .HasData(new Engine()
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
                });

            base.OnModelCreating(builder);
        }

    }
}