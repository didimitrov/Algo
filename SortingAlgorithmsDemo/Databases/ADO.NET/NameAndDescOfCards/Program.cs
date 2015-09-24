using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameAndDescOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            var output = new StringBuilder();

            var dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");

            dbCon.Open();

            using (dbCon)
            {
                SqlCommand catNamesAndDesc = new SqlCommand(@"SELECT CategoryName, [Description] FROM Categories", dbCon);

                SqlDataReader dbInfo = catNamesAndDesc.ExecuteReader();

                using (dbInfo)
                {
                    while (dbInfo.Read())
                    {
                        output.AppendFormat("Name: {0}, Description: {1}", dbInfo["CategoryName"], dbInfo["Description"]);
                        output.AppendLine();
                    }
                }
            }

            Console.WriteLine(output.ToString());

        }
    }
}
