using RentACarApp.Contracts;
using RentACarApp.Data;
using RentACarApp.Data.Entities;

namespace RentACarApp.Services
{
    public class AgentService : IAgentService
    {
        private readonly RentACarAppDbContext context;

        public AgentService(RentACarAppDbContext _context)
        {
            context = _context;
        }

        public void Create(string userId, string phoneNumber)
        {
            var agent = new Agent()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            context.Agents.Add(agent);
            context.SaveChanges();
        }

        public bool ExistsById(string userId)
        {
            return context.Agents.Any(a => a.UserId == userId);
        }

        public int GetAgentId(string userId)
        {
            return (context.Agents
                .FirstOrDefault(a => a.UserId == userId))?.Id ?? 0;
        }

        public bool AgentWithPhoneNumberExists(string phoneNumber)
        {
            return context.Agents
                .Any(a => a.PhoneNumber == phoneNumber);
        }
    }
}
