using RentACarApp.Data.Entities;

namespace RentACarApp.Models
{
    public class AgentServiceModel
    {
        public string UserName { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public string? Email { get; set; } = null;

        public string? FirstName { get; set; } = null;

        public string? LastName { get; set; } = null;

    }
}
