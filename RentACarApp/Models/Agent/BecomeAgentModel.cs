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

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? FirstName { get; set; } = null;

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? LastName { get; set; } = null;
    }
}
