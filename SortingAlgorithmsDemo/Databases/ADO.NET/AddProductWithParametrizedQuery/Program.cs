using System.Data.SqlClient;

namespace AddProductWithParametrizedQuery
{
    class Program
    {
        private static SqlConnection dbCon;

        private static void ConnectToDb()
        {
            var dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
           "Database=Northwind; Integrated Security=true");

            dbCon.Open();
        }

        private static int AddProduct(
            string productname,
            int supplierId,
            int categoryId,
            string quantityPerUnit,
            decimal unitPrice,
            int unitsInStock,
            int unitsOnOrder,
            int reorderLevel,
            int discontinued)
        {
            SqlCommand insertProduct = new SqlCommand(@"INSERT INTO Products (
                                                                ProductName,
                                                                SupplierID,
                                                                CategoryID,
                                                                QuantityPerUnit, 
                                                                UnitPrice, 
                                                                UnitsInStock,
                                                                UnitsOnOrder,
                                                                ReorderLevel,
                                                                Discontinued)
	VALUES (@name, @supId, @catId, @quantPerUnit, @unitPrice, 
                                                                    @unitsInStock, @unitsInOrer, @reorderedLvl,  
                                                                    @discontinued)",dbCon);

            insertProduct.Parameters.AddWithValue("@name", productname);
            insertProduct.Parameters.AddWithValue("@supId", supplierId);
            insertProduct.Parameters.AddWithValue("@catId", categoryId);
            insertProduct.Parameters.AddWithValue("@quantPerUnit", quantityPerUnit);
            insertProduct.Parameters.AddWithValue("@unitPrice", unitPrice);
            insertProduct.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            insertProduct.Parameters.AddWithValue("@unitsInOrder", unitsOnOrder);
            insertProduct.Parameters.AddWithValue("@reorderedLvl", reorderLevel);
            insertProduct.Parameters.AddWithValue("@discontinued", discontinued);

            insertProduct.ExecuteNonQuery();

            SqlCommand selectIdentity = new SqlCommand("select @@Identity", dbCon);

            int insertedRecordId = (int) selectIdentity.ExecuteScalar();

            return insertedRecordId;
        }

        static void Main(string[] args)
        {
//             var connection = new SqlConnection(Settings.Default.DbConnection);
//            connection.Open();

//            var productName = "Jacobs Ice Coffee";
//            var supplierId = 15;
//            var categoryId = 1;
//            var quantityPerUnit = "50 packages x 36 g";
//            var unitPrice = 0.45d;
//            var unitsInStock = 250;
//            var unitsInOrder = 125;
//            var reorderLevel = 45;
//            var discontinued = 0;

//            using (connection)
//            {
//                SqlCommand sqlCommand =
//                new SqlCommand(@"INSERT INTO Products
//                             VALUES (@productName, @supplierId, @categoryId, @quantityPerUnit, @unitPrice, 
//                                     @unitsInStock, @unitsInOrder, @reorderLevel, @discontinued)", connection);

//                sqlCommand.Parameters.AddWithValue("@productName", productName);
//                sqlCommand.Parameters.AddWithValue("@supplierId", supplierId);
//                sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
//                sqlCommand.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
//                sqlCommand.Parameters.AddWithValue("@unitPrice", unitPrice);
//                sqlCommand.Parameters.AddWithValue("@unitsInStock", unitsInStock);
//                sqlCommand.Parameters.AddWithValue("@unitsInOrder", unitsInOrder);
//                sqlCommand.Parameters.AddWithValue("@reorderLevel", reorderLevel);
//                sqlCommand.Parameters.AddWithValue("@discontinued", discontinued);

//                var queryResult = sqlCommand.ExecuteNonQuery();

//                Console.WriteLine("({0} row(s) affected)", queryResult);
        }
    }
}
