using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Cars.Models
{
    public class Dealer
    {
        public Dealer()
        {
            this.Cities = new HashSet<City>();
            this.Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
