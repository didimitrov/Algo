
using System;
using Computers.UI.Console.Factory;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    public class Engine
    {
        private static Engine instance;

        private Engine()
        {
        }

        public static Engine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Engine();
                }

                return instance;
            }
        }

        public IDesktop Desktop { get; private set; }

        public IServer Server { get; private set; }

        public ILaptop Laptop { get; private set; }

        public void Run()
        {
            string userInput =System.Console.ReadLine();

            switch (userInput)
            {
                case "HP":
                    var hp = new HpFactory();
                    this.CreateComputers(hp);
                    break;

                case "Dell":
                    IComputerFactory dell = new DellFactory();
                    this.CreateComputers(dell);
                    break;

                //case "Lenovo":
                //    IComputerFactory lenovo = new LenovoFactory();
                //    this.CreateComputers(lenovo);
                //    break;

                default:
                    throw new ArgumentException("Invalid manufacturer!");
            }

            this.CommandExecuter();
        }

        private void CommandExecuter()
        {
            while (true)
            {
                string userInput = System.Console.ReadLine();

                if (userInput == null || userInput.StartsWith("Exit"))
                {
                    break;
                }

                var command = this.ParseCommand(userInput);

                switch (command.Name)
                {
                    case "Charge":
                        this.Laptop.ChargeBattery(command.Argument);
                        break;

                    case "Process":
                        this.Server.Process(command.Argument);
                        break;

                    case "Play":
                        this.Desktop.Play(command.Argument);
                        break;

                    default:
                        System.Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }

        private void CreateComputers(IComputerFactory factory)
        {
            var creator = new ComputerCreator(factory);

            this.Desktop = creator.AssembleDesktop();
            this.Server = creator.AssembleServer();
            this.Laptop = creator.AssembleLaptop();
        }

        private CommandType ParseCommand(string userInput)
        {
            var command = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (command.Length != 2)
            {
                throw new ArgumentException("Invalid command!");
            }

            string commandName = command[0];
            int commandArguments = int.Parse(command[1]);

            return new CommandType(commandName, commandArguments);
        }
    }
}
