using System.Data.Entity;
using Cars.Models;

namespace Cars.Data.Contracts
{
    public interface ICarsDbContext
    {
        IDbSet<Manufacturer> Manufacturers { get; set; }

        IDbSet<Car> Cars { get; set; }

        IDbSet<Dealer> Dealers { get; set; }

        IDbSet<City> Cities { get; set; }

        int SaveChanges();
    }
}
