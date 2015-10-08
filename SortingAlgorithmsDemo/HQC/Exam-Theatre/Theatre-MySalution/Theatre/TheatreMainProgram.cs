using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Theatre.Contracts;

namespace Theatre
{
    public class TheatreMainProgram
    {
        public static IPerformanceDatabase Database = new PerformanceDatabase();

        protected static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-EN");
           
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == null)
                {
                    return;
                }

                if (inputLine != String.Empty)
                {
                    string[] inputParts = inputLine.Split('(');
                    string chiHuy = inputParts[0];
                    string chiHuyResult;
                    try
                    {
                        switch (chiHuy)
                        {
                            case "AddTheatre":
                                inputParts = inputLine.Split('(');
                                chiHuy = inputParts[0];
                                string[] chiHuyParts1 = inputLine.Split(new[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                                string[] chiHuyParams1 = chiHuyParts1.Skip(1).Select(p => p.Trim()).ToArray();
                                string[] chiHuyParams = chiHuyParams1;
                                chiHuyResult = CommandManager.ExecuteAddTheatreCommand(chiHuyParams);
                                break;

                            case "PrintAllTheaters":
                                chiHuyResult = CommandManager.ExecutePrintAllTheatresCommand();
                                break;

                            case "AddPerformance":
                                inputParts = inputLine.Split('(');
                                chiHuy = inputParts[0];
                                chiHuyParts1 = inputLine.Split(new[] { '(', ',', ')' },
                                StringSplitOptions.RemoveEmptyEntries);
                                chiHuyParams1 = chiHuyParts1.Skip(1).Select(p => p.Trim()).ToArray();
                                chiHuyParams = chiHuyParams1;
                                string theatreName = chiHuyParams[0];
                                string performanceTitle = chiHuyParams[1];
                                DateTime result = DateTime.ParseExact(chiHuyParams[2], "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
                                DateTime startDateTime = result;
                                TimeSpan result2 = TimeSpan.Parse(chiHuyParams[3]);
                                TimeSpan duration = result2;
                                decimal result3 = Decimal.Parse(chiHuyParams[4], NumberStyles.Float);
                                decimal price = result3;

                                Database.AddPerformance(theatreName, performanceTitle, startDateTime, duration, price);
                                chiHuyResult = "Performance added";
                                break;

                            case "PrintAllPerformances":
                                chiHuyResult = CommandManager.ExecutePrintAllPerformancesCommand();
                                break;

                            case "PrintPerformances":
                                inputParts = inputLine.Split('(');
                                chiHuy = inputParts[0];
                                chiHuyParts1 = inputLine.Split(new[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                                chiHuyParams1 = chiHuyParts1.Skip(1).Select(p => p.Trim()).ToArray();
                                chiHuyParams = chiHuyParams1;
                                string theatre = chiHuyParams[0];
                                var performances = Database.ListPerformances(theatre)
                                    .Select(p =>
                                    {
                                        string result1 = p.StartDate.ToString("dd.MM.yyyy HH:mm");
                                        return String.Format("({0}, {1})", p.PerformanceTitle, result1);
                                    }).ToList();
                                if (performances.Any())
                                {
                                    chiHuyResult = string.Join(", ", performances);
                                }
                                else
                                {
                                    chiHuyResult = "No performances";


                                }
                                break;
                            default:
                                chiHuyResult = "Invalid command!";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        chiHuyResult = "Error: " + ex.Message;
                    }

                    Console.WriteLine(chiHuyResult);
                }
            }
        }
    }
}
