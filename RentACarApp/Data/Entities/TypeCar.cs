using System.ComponentModel.DataAnnotations;

namespace RentACarApp.Data.Entities
{
    public class TypeCar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
