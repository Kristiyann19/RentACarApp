using RentACarApp.Data;
using RentACarApp.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace RentACarApp.Models
{
    public class AddCarViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Make { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Model { get; set; }

        [Required]
        [RangeUntilCurrentYear(1930, ErrorMessage = "Please enter a valid year")]
        public int Year { get; set; }

        [Required]
        [Range(typeof(decimal), "0.0", "1000000.0", ConvertValueInInvariantCulture = true)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 2000)]
        public int HorsePower { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Color { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int TypeCarId { get; set; }

        public IEnumerable<TypeCar> TypeCars { get; set; } = new List<TypeCar>();

        public int EngineId { get; set; }

        public IEnumerable<Engine> Engines { get; set; } = new List<Engine>();
    }
}
