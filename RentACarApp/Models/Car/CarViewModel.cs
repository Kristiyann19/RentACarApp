using System.ComponentModel.DataAnnotations;

namespace RentACarApp.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public int HorsePower { get; set; }

        public string Color { get; set; }

        public string ImageUrl { get; set; }

        public string? TypeCar { get; set; }

        public string? Engine { get ; set; }

        [Display(Name = "Is Rented")]
        public bool IsRented { get; set; } 
    }
}



