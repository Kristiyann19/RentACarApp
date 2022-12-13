using RentACarApp.Data.Entities;

namespace RentACarApp.Models
{
    public class AgentServiceModel
    {
        public string PhoneNumber { get; set; } = null!;

        public string? Email { get; set; } = null;

        public string? FirstName { get; set; } = null;

        public string? LastName { get; set; } = null;

        public IEnumerable<Car> Cars { get; set; } = new List<Car>();

    }
}
