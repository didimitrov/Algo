using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;

namespace Cars.Models
{
    public class Manufacturer
    {
        private ICollection<Car> _cars;

        public Manufacturer()
        {
            this.Cars = new HashSet<Car>();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
     
        public string  Name { get; set; }

        public virtual ICollection<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }
    }
}
