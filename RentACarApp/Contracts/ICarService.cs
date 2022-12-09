using RentACarApp.Data.Entities;
using RentACarApp.Models;

namespace RentACarApp.Contracts
{
    public interface ICarService
    {
        Task<IEnumerable<CarViewModel>> GetAllCarsAsync();

        bool IsRented();

        bool Exists(int id);

        Task<IEnumerable<Engine>> GetEngneAsync();

        Task<IEnumerable<TypeCar>> GetTypeCarAsync();

        Task<CarViewModel> GetCarDetails(int carId);

        Task RentCarToCartAsync(int carId, string userId);

        Task RemoveCarFromCartAsync(int carId, string userId);

        Task AddCarForRentAsync(AddCarViewModel modell);

        Task<IEnumerable<CarViewModel>> GetRentedAsync(string userId);

        void Delete(int carId);

    }
}
