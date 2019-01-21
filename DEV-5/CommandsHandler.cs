using System;
using System.Text;
using System.Collections.Generic;

namespace DEV_5
{
    /// <summary>
    /// Handles command line commands
    /// </summary>
    partial class CommandsHandler
    {
        private static CarsHouse Storage;

        // Possible commands
        private const string Exit = "exit";
        private const string CountBrands = "count types";
        private const string CountAll = "count all";
        private const string AveragePrice = "average price";
        private const string AveragePriceForBrand = "average price ";

        private Dictionary<string, ICommand> CommandsDictionary;

        public CommandsHandler(CarsHouse carsHouse)
        {
            Storage = carsHouse;
            CommandsDictionary = new Dictionary<string, ICommand>()
            {
                [Exit] = new ExitCommand(),
                [CountBrands] = new CountBrandsCommand(Storage),
                [CountAll] = new CountAllCommand(Storage),
                [AveragePrice] = new AveragePriceCommand(Storage),
                [AveragePriceForBrand] = new AveragePriceForBrandCommand(Storage)
            };
        }

        /// <summary>
        /// Tries to find and execute command from CommandsDictionry
        /// </summary>
        /// <param name="command">Command name, command parameters</param>
        public void HandleCommand(string command)
        {
            if (CommandsDictionary.ContainsKey(command))
            {
                CommandsDictionary[command].Execute();
            }
            else if(!TryToExecuteWithArguments(command))
            {
                Console.WriteLine("Wrong command.");
            }
        }

        /// <summary>
        /// Tries to find and execute command with parameter from CommandsDictionry
        /// </summary>
        /// <param name="carsHouse">List of cars that must be passed to command</param>
        /// <param name="command">Command name, command parameters</param>
        /// <returns>True if succeeded, false otherwise</returns>
        private bool TryToExecuteWithArguments(string command)
        {
            string[] splittedCommand = command.Split(' ');
            command = "";
            for (int i = 0; i < splittedCommand.Length; i++)
            {
                command += splittedCommand[i] + " ";
                if (CommandsDictionary.ContainsKey(command))
                {
                    CommandsDictionary[command].Execute(splittedCommand[i + 1]);
                    return true;
                }
            }

            return false;
        }

        private void TryToExecute(CarsHouse carsHouse, string command)
        {

        }

        /// <summary>
        /// Extracts command parameter if presents
        /// </summary>
        /// <param name="command">Command to extract from</param>
        /// <returns>Command parameter</returns>
        private string ExtractCommandParameter(string command)
        {
            StringBuilder commandParameter = new StringBuilder(command);
            if (command.Contains("'"))
            {
                commandParameter.Remove(0, command.IndexOf("'") + 1);
            }

            return commandParameter.ToString();
        }
    }
}