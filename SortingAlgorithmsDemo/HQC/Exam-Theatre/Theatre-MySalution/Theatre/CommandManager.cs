using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Theatre.Contracts;

namespace Theatre
{
    public class CommandManager
    {
        private static readonly IPerformanceDatabase Database = new PerformanceDatabase();

        public static string AddTheatreCommand(string[] parameters)
        {
            string theatreName = parameters[0];
            Database.AddTheatre(theatreName);
            return "Theatre added";
        }

        public static string PrintAllTheatresCommand()
        {
          //if (Database.ListTheatres().Any())
          //  {
          //      return string.Join(",", Database.ListTheatres());
          //  }
          //  return "No Theatres";
            var theatresCount = Database.ListTheatres().Count();
            return theatresCount <= 0 ? "No theatres" : string.Join(", ", Database.ListTheatres());
        }

        public static string PrintAllPerformances()
        {
            var performances = Database.ListAllPerformances().ToList();
           
            if (!performances.Any())
            {
                return "No performances";
            }
            var allPerformancesInfo =
                performances.Select(p => string.Format("{0}, {1}, {2}", p.PerformanceTitle, p.TheatreName, p.StartDate));

            return string.Join(",", allPerformancesInfo);
        }

        //public static string AddPerformance
        //    (string theatreName,string  performanceTitle,DateTime dateTime,TimeSpan duration,decimal price)
        //{
        //    Database.AddPerformance(theatreName,performanceTitle,dateTime, duration, price);
        //    return "Performance added";
        //}

        public static string AddPerformance(string[] commandParameters)
        {
            var theatreName = commandParameters[0];
            var performanceTitle = commandParameters[1];
            var startDateTime = DateTime.ParseExact(commandParameters[2], "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
            var duration = TimeSpan.Parse(commandParameters[3]);
            var price = decimal.Parse(commandParameters[4], NumberStyles.Float);
           
            Database.AddPerformance(theatreName, performanceTitle, startDateTime, duration, price);
            return "Performance added";
        }

        public string PrintPerformances(string[] commandParameters)
        {
            var theatre = commandParameters[0];
            var performances = Database.ListPerformances(theatre).Select(p =>
            {
                var startTime = p.StartDate.ToString("dd.MM.yyyy HH:mm");
                return string.Format("({0}, {1})", p.PerformanceTitle, startTime);
            }).ToList();

            if (performances.Any())
            {
                return string.Join(",", performances);
            }
            return "No performances";
        }
    }
}
