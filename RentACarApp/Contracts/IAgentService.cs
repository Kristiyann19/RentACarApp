namespace RentACarApp.Contracts
{
    public interface IAgentService
    {
        bool ExistsById(string userId);

        bool AgentWithPhoneNumberExists(string phoneNumber);

        void Create(string userId, string phoneNumber);

        int GetAgentId(string userId);

    }
}
