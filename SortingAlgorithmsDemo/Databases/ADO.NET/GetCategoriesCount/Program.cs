using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCategoriesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                               "Database=Northwind; Integrated Security=true");
            connection.Open();

            using (connection)
            {
                SqlCommand sql = new SqlCommand("select count(CategoryId) from Categories", connection);

                Console.WriteLine("Number of rows in Categories is {0}", sql.ExecuteScalar());
            }
        }
    }
}
