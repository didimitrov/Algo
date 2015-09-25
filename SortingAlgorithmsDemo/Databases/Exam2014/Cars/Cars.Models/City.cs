
using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
    public class City
    {
        public int Id { get; set; }
        [Microsoft.Build.Framework.Required]
        [MaxLength(10)]
        public string  Name { get; set; }
    }
}
