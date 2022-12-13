using Microsoft.AspNetCore.Identity;

namespace RentACarApp.Data.Entities
{
    public class User : IdentityUser
    {
        

        public bool IsActive { get; set; } = true;

        public List<UserCars> UsersCars { get; set; } = new List<UserCars>();
    }
}
