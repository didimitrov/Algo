/*
 * NOTE: Please check your connectionString, I'm using . (localhost)
 * If your Ms SQL Server is express please change in Context class in .Data Project
        public CodeFirstContext()
            : base(ConnectionStrings.Default.MsSql) { ...}
    To:
        public CodeFirstContext()
            : base(ConnectionStrings.Default.MsSqlExpress) { ...}
 */
namespace Cars.ConsoleClient
{
    using System;
    using Data;
    

    class EntryPoint
    {
        private const string CarsImportJsonFilesPath = "../../../DataJsonFiles";
        private const string QueriesXmlFilePath = "../../Queries.xml";
        private const string QueriesResultExportXmlFilePath = "../../../output/";

        private static readonly CarsDbContext CarsContext = new CarsDbContext();
        private static readonly DataJsonImporter DataJsonImporter = new DataJsonImporter(CarsContext);
        private static readonly QueryXmlParser QueryXmlParser = new QueryXmlParser(CarsContext);

        static void Main()
        {
            using (CarsContext)
            {
                Console.WriteLine("Loading...");

                DataJsonImporter.Import(CarsImportJsonFilesPath);
                QueryXmlParser.GetResults(QueriesXmlFilePath, QueriesResultExportXmlFilePath);
            }
        }
    }
}
