using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theatre.Contracts;
using Theatre.Exceptions;

namespace Theatre.Tests
{
    [TestClass]
    public class AddPerformanceTest
    {
        private IPerformanceDatabase _database;
        private Performance performance1;
        private Performance performance2;
        private Performance performance3;
       
        [TestInitialize]
        public void TestInitialize()
        {
            this._database = new PerformanceDatabase();
            this._database.AddTheatre("Theatre Sofia");
            this._database.AddTheatre("Theatre 199");

            // Theatre 199, Duende, 20.01.2015 20:00, 1:30, 14.5
            this.performance1 = new Performance(
                "Theatre 199",
                "Duende",
                new DateTime(2015, 1, 19, 20, 0, 0),
                new TimeSpan(0, 1, 30, 0),
                14.5M);

            // Theatre 199, Bella Donna, 20.01.2015 20:30, 1:00, 12)
            this.performance2 = new Performance(
                "Theatre 199",
                "Bella Donna",
                new DateTime(2015, 1, 20, 20, 30, 0),
                new TimeSpan(0, 1, 0, 0),
                12.0M);

            // Theatre Sofia, Don Juan, 20.01.2015 20:31, 2:00, 14.60
            this.performance3 = new Performance(
                "Theatre Sofia",
                "Don Juan",
                new DateTime(2015, 1, 20, 20, 31, 0),
                new TimeSpan(0, 2, 0, 0),
                14.6M);
        }

        [TestMethod]
        public void AddPerformances_AddPerformanses()
        {
            this._database.AddPerformance(
              "Theatre 199",
              "Duende",
              new DateTime(2015, 1, 19, 20, 0, 0),
              new TimeSpan(0, 1, 30, 0),
              14.5M);
            this._database.AddPerformance(
                "Theatre 199",
                "Bella Donna",
                new DateTime(2015, 1, 20, 20, 30, 0),
                new TimeSpan(0, 1, 0, 0),
                12.0M);
            this._database.AddPerformance(
                "Theatre Sofia",
                "Don Juan",
                new DateTime(2015, 1, 20, 20, 31, 0),
                new TimeSpan(0, 2, 0, 0),
                14.6M);

            Assert.AreEqual(3, _database.ListAllPerformances().Count());
            Assert.AreEqual(2, _database.ListPerformances("Theatre 199").Count());
            Assert.AreEqual(1, _database.ListPerformances("Theatre Sofia").Count());

            var expected = new[] {this.performance1, this.performance2, this.performance3}.Select(p => p.ToString());
            var actual = _database.ListAllPerformances().Select(p => p.ToString());
            Assert.AreEqual(string.Join(",", expected), string.Join(",", actual));

             expected = new[] { this.performance1, this.performance2 }.Select(p => p.ToString());
             actual = _database.ListPerformances("Theatre 199").Select(p => p.ToString());
            Assert.AreEqual(string.Join(",", expected), string.Join(",", actual));
        }

        [TestMethod]
        [ExpectedException(typeof(TheatreNotFoundException))]
        public void AddPperformance_TheatreNotFound()
        {
            _database.AddPerformance(
                "Theatre Shoumen",
                "Don Juan",
                new DateTime(2015, 1, 20, 20, 31, 0),
                new TimeSpan(0, 2, 0, 0),
                14.6M);
        }

        [TestMethod]
        [ExpectedException(typeof(TimeDurationOverlapException))]
        public void AddPerformance_Overlap()
        {
            _database.AddPerformance(
                 "Theatre Sofia",
                 "Don Huan",
                 new DateTime(2015, 1, 20, 20, 31, 0),
                 new TimeSpan(0, 2, 0, 0),
                 14.6M);
            
            _database.AddPerformance(
                 "Theatre Sofia",
                 "Don Pedro",
                 new DateTime(2015, 1, 20, 20, 31, 0),
                 new TimeSpan(0, 2, 0, 0),
                 14.6M); 
        }
    }
}
