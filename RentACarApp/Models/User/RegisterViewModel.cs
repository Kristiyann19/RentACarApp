using System.ComponentModel.DataAnnotations;

namespace RentACarApp.Models
{
    public class RegisterViewModel
    { 
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength (50, MinimumLength = 9)]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [StringLength (30, MinimumLength = 6)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;

    }
}
