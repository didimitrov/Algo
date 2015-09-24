using System;
using System.Data.SqlClient;

namespace CategoriesAndProductsName
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");

          dbCon.Open();

            using (dbCon)
            {
                SqlCommand sql = new SqlCommand(@"SELECT ProductName, CategoryName
                                                            FROM Categories cat
                                                            JOIN Products pro
                                                            ON pro.CategoryID = cat.CategoryID
                                                            ORDER BY CategoryName", dbCon);

                var reader = sql.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} - {1}", reader["ProductName"], reader["CategoryName"]);
                    }
                }

            }
        }
    }
}
