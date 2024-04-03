// Product.cs (Model)
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string BusinessName { get; set; }

        [Required]
        public string BusinessDescription { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Address { get; set; }

        // Add other properties as needed
    }
}
