using Microsoft.EntityFrameworkCore;
using RentACarApp.Contracts;
using RentACarApp.Data;
using RentACarApp.Data.Entities;
using RentACarApp.Models;
using System.Linq;

namespace RentACarApp.Services
{
    public class CarService : ICarService
    {
        private readonly RentACarAppDbContext context;

        public CarService(RentACarAppDbContext _context)
        {
            context = _context;
        }


        public async Task RentCarToCartAsync(int carId, string userId)
        {
            var user = await context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.UsersCars)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid User Id");
            }

            var car = await context.Cars
                .Where(c => c.Id == carId)
                .Include(c => c.TypeCar)
                .Include(c => c.Engine)
                .FirstOrDefaultAsync();

            if (car == null)
            {
                throw new ArgumentException("Invalid Car Id");
            }

            if (!user.UsersCars.Any(c => c.CarId == carId))
            {
                user.UsersCars.Add(new UserCars()
                {
                    CarId = car.Id,
                    UserId = user.Id,
                    Car = car,
                    User = user
                });

                await context.SaveChangesAsync();
            }
        }


        public bool Exists(int id)
        => context.Cars.Any(c => c.Id == id);


        public async Task<IEnumerable<CarViewModel>> GetAllCarsAsync()
        {
            var entities = await context.Cars
                .Include(c => c.TypeCar)
                .Include(c => c.Engine)
                .ToListAsync();

            return entities
                .Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    Year = c.Year,
                    Color = c.Color,    
                    HorsePower = c.HorsePower,
                    TypeCar = c.TypeCar.Name,
                    Engine = c.Engine.Name,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl
                });
        }


        public async Task<CarViewModel> GetCarDetails(int carId)
        {

            return await context.Cars
                .Include(c => c.TypeCar)
                .Include(c => c.Engine)
                .Where(c => c.Id == carId)
                .Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    Year = c.Year,
                    Color = c.Color,
                    HorsePower = c.HorsePower,
                    TypeCar = c.TypeCar.Name,
                    Engine = c.Engine.Name,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl
                }).FirstAsync();

        }

        public async Task<IEnumerable<CarViewModel>> GetRentedAsync(string userId)
        {
            var user = await context.Users
               .Where(u => u.Id == userId)
               .Include(u => u.UsersCars)
               .ThenInclude(uc => uc.Car)  
               .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }


            return user.UsersCars
                .Select(c => new CarViewModel()
                {
                    Id = c.Car.Id,
                    Make = c.Car.Make,
                    Model = c.Car.Model,
                    Year = c.Car.Year,
                    Color = c.Car.Color,
                    HorsePower = c.Car.HorsePower,
                    Price = c.Car.Price,
                    ImageUrl = c.Car.ImageUrl
                });
        }

        public async Task RemoveCarFromCartAsync(int carId, string userId)
        {
            var user = await context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.UsersCars)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid User Id");
            }


            var car = user.UsersCars.FirstOrDefault(c => c.CarId == carId);

            if (car != null)
            {
                user.UsersCars.Remove(car);

                await context.SaveChangesAsync();    
            }
        }

        public async Task AddCarForRentAsync(AddCarViewModel modell)
        {
            var entity = new Car()
            {
                Make = modell.Make,
                Model = modell.Model,
                Year = modell.Year,
                Color = modell.Color,
                HorsePower = modell.HorsePower,
                TypeCarId = modell.TypeCarId,
                EngineId = modell.EngineId,
                Price = modell.Price,
                ImageUrl = modell.ImageUrl
            };

            await context.Cars.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Engine>> GetEngneAsync()
        {
            return await context.Engines.ToListAsync();
        }

        public async Task<IEnumerable<TypeCar>> GetTypeCarAsync()
        {
            return await context.Types.ToListAsync();
        }

        public void Delete(int carId)
        {
            var car = context.Cars.FirstOrDefault(c => c.Id == carId);

            context.Remove(car);
            context.SaveChanges();
        }
    }
}
