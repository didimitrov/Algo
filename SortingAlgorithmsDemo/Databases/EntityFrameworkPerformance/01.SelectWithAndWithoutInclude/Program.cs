//Using Entity Framework write a SQL query to select all employees from the 
//Telerik Academy database and later print their name, department and town. 
//Try the both variants: with and without .Include(…). 
//Compare the number of executed SQL statements and the performance.

using System;

namespace _01.SelectWithAndWithoutInclude
{
    class Program
    {
        public static void SelectAllEmployeesWithoutInclude(TelerikAcademyEntities context)
        {
            using (context)
            {
               foreach (var entity in context.Employees)
                {
                    Console.WriteLine("Name {0}, Department {1}, Town {2}", 
                        entity.FirstName, entity.Department.Name, entity.Address.Town.Name);
                }
            }
        }

        public static void SelectallEmployeesWithInclude(TelerikAcademyEntities context)
        {
            using (context)
            {
                foreach (var item in context.Employees.Include("Departments").Include("Adressess.Town"))
                {
                    Console.WriteLine("Name {0}, Department {1}, Town {2}",
                        item.FirstName, item.Department.Name, item.Address.Town.Name);
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
