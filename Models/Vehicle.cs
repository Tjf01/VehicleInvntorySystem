using System.ComponentModel.DataAnnotations;

namespace VehicleInventorySystem.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Range(2000, int.MaxValue, ErrorMessage = "Please enter a valid year.")]
        public int Year { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid price.")]
        public int Price { get; set; }

        public string Description { get; set; }
    }
}
