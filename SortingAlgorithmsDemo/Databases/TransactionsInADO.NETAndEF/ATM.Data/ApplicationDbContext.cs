using System.Data.Entity;
using ATM.Data.Migrations;
using ATM.Models;

namespace ATM.Data
{
    public class ApplicationDbContext : DbContext
    {
        private const string AtmDatabaseName = "ATM";

        public ApplicationDbContext()  :base(AtmDatabaseName)
        {
            System.Data.Entity.Database.SetInitializer
                (new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public DbSet<CardAccount> CardAccounts { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
        
    }
}
