using System;
using Microsoft.Build.Framework;

namespace Cars.Models
{
    public class Car
    {
        public int Id { get; set; }
       
        [Required]
        public string  Model { get; set; }
       
        [Required]
        public decimal Price { get; set; }
        
        public int Year { get; set; }
        
        [Required]
        public Transmission Transmission { get; set; }

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        public int DealerId { get; set; }
        public virtual Dealer Dealer { get; set; }


    }
}
