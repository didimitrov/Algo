using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theatre
{
    public class CommandManager
    {
        public static string ExecuteAddTheatreCommand(string[] parameters)
        {
            string theatreName = parameters[0];
            TheatreMainProgram.Database.AddTheatre(theatreName);
            return "Theatre added";
        }

        public static string ExecutePrintAllTheatresCommand()
        {
            var theatresCount = TheatreMainProgram.Database.ListTheatres().Count();
            if (theatresCount > 0)
            {
                var resultTheatres = new LinkedList<string>();
                for (int i = 0; i < theatresCount; i++)
                {
                    TheatreMainProgram.Database.ListTheatres()
                        .Skip(i).ToList()
                        .ForEach(t => resultTheatres.AddLast(t));
                    foreach (var t in TheatreMainProgram.Database.ListTheatres().Skip(i + 1))
                    {
                        resultTheatres.Remove(t);
                    }
                }
                return String.Join(", ", resultTheatres);
            }
            return "No theatres";
        }

        public static string ExecutePrintAllPerformancesCommand()
        {
            var performances = TheatreMainProgram.Database.ListAllPerformances().ToList();
            var result = String.Empty;
            if (performances.Any())
            {
                for (int i = 0; i < performances.Count; i++)
                {
                    var sb = new StringBuilder();
                    sb.Append(result);
                    if (i > 0)
                    {
                        sb.Append(", ");
                    }
                    string result1 = performances[i].StartDate.ToString("dd.MM.yyyy HH:mm");
                    sb.AppendFormat("({0}, {1}, {2})", performances[i].PerformanceTitle, performances[i].TheatreName,
                        result1);
                    result = sb + "";
                }
                return result;
            }
            return "No performances";
        }
    }
}
