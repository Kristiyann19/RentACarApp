using System.ComponentModel.DataAnnotations;

namespace RentACarApp.Data.Entities
{
    public class Engine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(8)]
        public string Name { get; set; } = null!;

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
