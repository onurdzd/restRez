using System;
using System.ComponentModel.DataAnnotations;

namespace RestoranRezervasyon.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int PeopleCount { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
