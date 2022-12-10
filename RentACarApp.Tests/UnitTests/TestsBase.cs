using NUnit.Framework;
using RentACarApp.Data;
using RentACarApp.Data.Entities;
using RentACarApp.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp.Tests
{
    public class TestsBase
    {
        protected RentACarAppDbContext context;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            context = DatabaseMock.Instance;
            SeedDatabase();
        }

        public User Renter { get; private set; }

        public Agent Agent { get; private set; }

        public Car RentedCar { get; private set; }

        private void SeedDatabase()
        {
            Renter = new User()
            {
                Id = "RenterUserId",
                Email = "renter@mail.com",
                UserName = "Renter",
                LastName = "Renterov"
            };

            context.Users.Add(Renter);

            Agent = new Agent()
            {
                PhoneNumber = "+359882365050",
                User = new User()
                {
                    Id = "TestUserId",
                    Email = "user@mail.com",
                    UserName = "Test",
                    LastName = "Testov"
                }
            };

            context.Agents.Add(Agent);

            RentedCar = new Car()
            {
                Make = "First Test Car",
                Model = "First Test Model",
                Year = 2021,
                Price = 1111,
                Color = "Test Color",
                HorsePower = 69,
                ImageUrl = "https://media.carsandbids.com/cdn-cgi/image/width=1800,quality=70/438ad923cef6d8239e95d61e7d6849486bae11d9/photos/KDgVJ2G8.NfXWiaxfK-(edit).jpg?t=164667913335",
                TypeCar = new TypeCar() { Name = "SUV" },
                Engine = new Engine() { Name = "Diesel" },
                Renter = Renter,
                Agent = Agent

            };

            context.Cars.Add(RentedCar);

            var nonRentedCar = new Car()
            {
                Make = "Second Test Car",
                Model = "Second Test Model",
                Year = 2022,
                Price = 2222,
                Color = "Test Color2",
                HorsePower = 699,
                ImageUrl = "https://media.carsandbids.com/cdn-cgi/image/width=1800,quality=70/438ad923cef6d8239e95d61e7d6849486bae11d9/photos/KDgVJ2G8.NfXWiaxfK-(edit).jpg?t=164667913335",
                TypeCar = new TypeCar() { Name = "Sedan" },
                Engine = new Engine() { Name = "Electric" },
                Renter = Renter,
                Agent = Agent

            };

            context.Cars.Add(nonRentedCar);
            context.SaveChanges();
        }

        [OneTimeTearDown]

        public void TearDownBase()       
             => context.Dispose();
        

    }
}
