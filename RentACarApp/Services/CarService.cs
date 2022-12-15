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


        public bool Exists(int id)
        =>  context.Cars.Any(c => c.Id == id);

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
                    ImageUrl = c.ImageUrl,
                    IsRented = c.RenterId != null    
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
                    ImageUrl = c.ImageUrl,
                    IsRented = c.RenterId != null,
                    
                })
                .FirstAsync();

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
                    ImageUrl = c.Car.ImageUrl,
                    IsRented = c.Car.IsRented = true

                });
        }

        

        public async Task AddCarForRentAsync(AddCarViewModel modell, int agentId)
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
                ImageUrl = modell.ImageUrl,
                IsRented = true,
                AgentId = agentId


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
            var car = await context.Cars
                .Where(c => c.Id == carId)
                .Include(c => c.TypeCar)
                .Include(c => c.Engine)
                .FirstOrDefaultAsync();

            var carFromUsersCars = user.UsersCars.FirstOrDefault(c => c.CarId == carId);

            if (car != null)
            {
                
                user.UsersCars.Remove(carFromUsersCars);
                car.RenterId = null;
                car.IsRented = false;
                await context.SaveChangesAsync();
            }
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
                car.RenterId = userId;
                car.IsRented = true;
                await context.SaveChangesAsync();
            }
        }

        public bool IsRented()
        {
            return context.Cars.Where(x => x.IsRented == true).Any();
        }

        public async Task<bool> HasAgentWithId(int carId, string currentUserId)
        {
            bool result = false;
            var car = await context.Cars 
                .Where(c => c.Id == carId)
                .Include(c => c.Agent)
                .FirstOrDefaultAsync();

            if (car?.Agent != null && car.Agent.UserId == currentUserId)
            {
                result = true;
            }

            return result;
        }

        public async Task<CarViewModel> GetAgentDetails(int carId)
        {
            return await context.Cars
                 .Where(c => c.Id == carId)
                 .Include(c => c.Engine)
                 .Include(c => c.TypeCar)
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
                     ImageUrl = c.ImageUrl,
                     IsRented = c.RenterId != null,
                     Agent = new AgentServiceModel()
                     {
                         UserName = c.Agent.User.UserName,
                         Email = c.Agent.User.Email,
                         PhoneNumber = c.Agent.PhoneNumber,
                         FirstName = c.Agent.FirstName,
                         LastName = c.Agent.LastName
                     }
                 })
                .FirstAsync();
        }
    }
}
