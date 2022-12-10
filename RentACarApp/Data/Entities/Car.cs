using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentACarApp.Data.Entities
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Make { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string Model { get; set; } = null!;

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Range(50, 2000)]
        public int HorsePower { get; set; }

        [Required]
        [MaxLength(30)]
        public string Color { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int EngineId { get; set; } 

        [ForeignKey(nameof(EngineId))]
        public Engine Engine { get; set; } = null!;

        [Required]
        public int TypeCarId { get; set; }

        [ForeignKey(nameof(TypeCarId))]
        public TypeCar TypeCar { get; set; } = null!;

        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public User? Renter { get; set; }

        [Required]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; }

        public bool IsRented { get; set; } 

        public List<UserCars> UsersCars { get; set; } = new List<UserCars>();

    }
}
