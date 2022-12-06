using System.ComponentModel.DataAnnotations;

namespace RentACarApp.Models
{
    public class BecomeAgentModel
    {
        [Required]
        [StringLength(15, MinimumLength = 7)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
    }
}
