using NUnit.Framework;
using RentACarApp.Contracts;
using RentACarApp.Data.Entities;
using RentACarApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp.Tests.UnitTests
{
    [TestFixture]
    public class CarServiceTest : TestsBase
    {
        private ICarService carService;

        [OneTimeSetUp]
        public void SetUp()
            => carService = new CarService(context);

        [Test]
        public void Exists_ShouldBeTrue()
        {
            var result = carService.Exists(RentedCar.Id);

            Assert.True(result);
        }

        [Test]
        public void Delete_ShouldDeleteCar()
        {
            var car = new Car()
            {
                Make = "New car to delete",
                Model = "Car to delete",
                Year = 2000,
                Color = "test color",
                ImageUrl = "https://media.carsandbids.com/cdn-cgi/image/width=1800,quality=70/438ad923cef6d8239e95d61e7d6849486bae11d9/photos/KDgVJ2G8.NfXWiaxfK-(edit).jpg?t=164667913335",

            };

            context.Cars.Add(car);
            context.SaveChanges();

            var carCountBefore = context.Cars.Count();

            carService.Delete(car.Id);

            var carCountAfter = context.Cars.Count();

            Assert.That(carCountAfter, Is.EqualTo(carCountBefore - 1));

            var carInDb = context.Cars.Find(car.Id);
            Assert.IsNull(carInDb);
        }
        
    }
}
