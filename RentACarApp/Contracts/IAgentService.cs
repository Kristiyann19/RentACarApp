namespace RentACarApp.Contracts
{
    public interface IAgentService
    {
        bool ExistsById(string userId);

        bool UserWithPhoneNumberExists(string phoneNumber);

        //Task<bool> UserHasRents(string userId);

        void Create(string userId, string phoneNumber);

    }
}
