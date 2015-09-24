using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Migrations;
using StudentSystem.Models;

namespace DataLibrary
{
    public class ApplicationDbContext : DbContext
    {
        private const string StudentSystemDbName = "StudentSystem";

        public ApplicationDbContext()
            : base(StudentSystemDbName)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Material> Materials { get; set; }
    }
}
