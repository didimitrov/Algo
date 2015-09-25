using System.Data.Entity;
using System.Management.Instrumentation;
using Cars.Data.Contracts;
using Cars.Data.Migrations;
using Cars.Models;

namespace Cars.Data
{
    public class CarsDbContext : DbContext, ICarsDbContext
    {
        public CarsDbContext()
            : base("CarsConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarsDbContext, Configuration>());
        }

        public IDbSet<Manufacturer> Manufacturers { get; set; }
        public IDbSet<Car> Cars { get; set; }
        public IDbSet<Dealer> Dealers { get; set; }
        public IDbSet<City> Cities { get; set; }
       
    }
}
