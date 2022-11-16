using Microsoft.EntityFrameworkCore;
using RentACarApp.Contracts;
using RentACarApp.Data;
using RentACarApp.Models;

namespace RentACarApp.Services
{
    public class CarService : ICarService
    {
        private readonly RentACarAppDbContext context;

        public CarService(RentACarAppDbContext _context)
        {
            context = _context;
        }

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
                    Description = c.Description,
                    TypeCar = c.TypeCar.Name,
                    Engine = c.Engine.Name,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl
                });
        }
    }
}
