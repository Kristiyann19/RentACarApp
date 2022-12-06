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

            context.AddAsync(agent);
            context.SaveChangesAsync();
        }

        public bool ExistsById(string userId)
        {
            return context.Agents.Any(a => a.UserId == userId);
        }


        //public async Task<bool> UserHasRents(string userId)
        //{
        //    return await context.c
        //        .AnyAsync(h => h.RenterId == userId);
        //}

        public bool UserWithPhoneNumberExists(string phoneNumber)
        {
            return context.Agents
                .Any(a => a.PhoneNumber == phoneNumber);
        }
    }
}
