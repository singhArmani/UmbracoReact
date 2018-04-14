
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
        public bool instock { get; set; }
    }
}
