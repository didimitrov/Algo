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
        public static CommandManager CommandManager= new CommandManager();

        protected static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string data;
            while ((data = Console.ReadLine()) != null)
            {
                if (data == string.Empty)
                {
                    continue;
                }

                string output;
                try
                {
                    output = CommandExecutor(data);
                }
                catch (Exception ex)
                {
                    output = "Error: " + ex.Message;
                }

                Console.WriteLine(output);
            }
        }

        private static string CommandExecutor(string text)
        {
            var commands = text.Split(new[] {'(', ',', ')'}, StringSplitOptions.RemoveEmptyEntries);
            var command = commands[0];
            var commandParameters = commands.Skip(1).Select(p => p).ToArray();

            string output = string.Empty;

            switch (command)
            {
                case "AddTheatre":
                    output = CommandManager.AddTheatreCommand(commandParameters);
                    break;
                case "PrintAllTheatres":
                    output = CommandManager.PrintAllTheatresCommand();
                    break;
                case "AddPerformance":
                    output = CommandManager.AddPerformance(commandParameters);
                    break;
                case "PrintAllPerformances":
                    output = CommandManager.PrintAllPerformances();
                    break;
                case "PrintPerformances":
                    output = CommandManager.PrintPerformances(commandParameters);
                    break;
                default:
                    output = "Invalid command!";
                    break;
            }
            return output;
        }
    }
}
