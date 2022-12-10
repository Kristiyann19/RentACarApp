using RentACarApp.Data.Entities;
using RentACarApp.Models;

namespace RentACarApp.Contracts
{
    public interface ICarService
    {
        Task<IEnumerable<CarViewModel>> GetAllCarsAsync();

        Task<CarViewModel> GetCarDetails(int carId);

        Task RentCarToCartAsync(int carId, string userId);

        Task RemoveCarFromCartAsync(int carId, string userId);

        Task AddCarForRentAsync(AddCarViewModel modell, int agentId);

        Task<IEnumerable<CarViewModel>> GetRentedAsync(string userId);

        Task<IEnumerable<Engine>> GetEngneAsync();

        Task<IEnumerable<TypeCar>> GetTypeCarAsync();

        void Delete(int carId);

        bool IsRented();

        bool Exists(int carId);

        Task<bool> HasAgentWithId(int carId, string currentUserId);

    }
}
