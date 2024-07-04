using System.ComponentModel.DataAnnotations;

namespace RestoranRezervasyon.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
