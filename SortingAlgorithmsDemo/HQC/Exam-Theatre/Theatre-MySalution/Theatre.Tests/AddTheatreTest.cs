using System;
using System.Collections.Specialized;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theatre.Contracts;
using Theatre.Exceptions;

namespace Theatre.Tests
{
    [TestClass]
    public class AddTheatreTest
    {
        private IPerformanceDatabase _database;

        [TestInitialize]
        public void TestInitialize()
        {
            this._database=new PerformanceDatabase();
        }

        [TestMethod]
        public void AddTheatre_AddTheatres()
        {
            _database.AddTheatre("Theatre Sofia");

            Assert.AreEqual(1,_database.ListTheatres().Count());

            CollectionAssert.AreEqual(new[] { "Theatre Sofia" },_database.ListTheatres().ToArray());

            _database.AddTheatre("Theatre 199");
            Assert.AreEqual(2, _database.ListTheatres().Count());
            CollectionAssert.AreEqual(new[] { "Theatre 199", "Theatre Sofia" }, _database.ListTheatres().ToArray());

        }

        [TestMethod]
        [ExpectedException(typeof (DuplicateTheatreException))]
        public void AddTheatre_Duplicates()
        {
            _database.AddTheatre("Theatre Sofia");
            _database.AddTheatre("Theatre Sofia");
        }
    }
}
