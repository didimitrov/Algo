using System;
using System.Data.SqlClient;
using System.Text;

namespace DemoAdoNet
{
    class Program
    {
        private static SqlConnection dbCon;
        private static StringBuilder sb;

        static void ListAllEmployees()
        {
            SqlCommand sqlCommand = new SqlCommand("select * from Employees");

            SqlDataReader reader = sqlCommand.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    sb.AppendFormat("{0} {1} - {2}", reader["FirstName"], reader["LastName"], reader["JobTitle"]);
                    sb.AppendLine();
                }
            }
        }

        static void AddEmployee(
            string firstName,string lastName, string middleName,
            string jobTitle, int departmentId, int managerId,
            DateTime hireDate, decimal salary, int addressId)
        {
            SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO Employees " +
                                                   "(FirstName, LastName, MiddleName, JobTitle," + 
                                                   "DepartmentID, ManagerID, HireDate, Salary, AddressID)
            VALUES (@firstName, @lastName, @middleName, @jobTitle,
                    @departmentId, @managerId, @hireDate, @salary, @addressId)", dbCon);
        }

        static void Main(string[] args)
        {
        }
    }
}
