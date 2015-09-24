/*
 * 2. Using Entity Framework write a query that selects all employees 
 * from the Telerik Academy database, then invokes ToList(), then selects
 * their addresses, then invokes ToList(), then selects their towns,
 * then invokes ToList() and finally checks whether the town is "Sofia".
 * Rewrite the same in more optimized way and compare the performance.
 */

using System;
using System.Linq;
using _01.SelectWithAndWithoutInclude;

namespace _02.SelectWithAndWithoutToList
{
    class Program
    {
        public static void SelectEmpInTown(TelerikAcademyEntities context, string town)
        {
            using (context)
            {
               // var employees = context.Employees.Where(x => x.Address.Town.Name == town);

                var employees = context.Employees
                                         .Select(e => e.Address)
                                         .Select(a => a.Town)
                                         .Where(t => t.Name == "Sofia")
                                         .ToList();

                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.FirstName+" "+employee.LastName);
                }
            }
        } 
        static void Main(string[] args)
        {
        }
    }
}
