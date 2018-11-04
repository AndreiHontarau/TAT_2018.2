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
        // Possible commands
        private const string Help = "help";
        private const string Exit = "exit";
        private const string CountBrands = "count types";
        private const string CountAll = "count all";
        private const string AveragePrice = "average price";
        private const string AveragePriceForBrand = "average price ";

        private Dictionary<string, IExecutable> CommandsDictionary = new Dictionary<string, IExecutable>()
        {
            [Help] = new HelpCommand(),
            [Exit] = new ExitCommand(),
            [CountBrands] = new CountBrandsCommand(),
            [CountAll] = new CountAllCommand(),
            [AveragePrice] = new AveragePriceCommand(),
            [AveragePriceForBrand] = new AveragePriceForBrandCommand()
        };

        /// <summary>
        /// Tries to find and execute command from CommandsDictionry
        /// </summary>
        /// <param name="CarsList">List of cars that must be passed to command</param>
        /// <param name="command">Command name, command parameters</param>
        public void HandleCommand(CarsHouse carsHouse, string command)
        {
            if (CommandsDictionary.ContainsKey(command))
            {
                CommandsDictionary[command].Execute(carsHouse);
            }
            else if(!TryToExecuteWithArguments(carsHouse, command))
            {
                Console.WriteLine("Wrong command. For help enter \"help\".");
            }
        }

        /// <summary>
        /// Tries to find and execute command with parameter from CommandsDictionry
        /// </summary>
        /// <param name="carsHouse">List of cars that must be passed to command</param>
        /// <param name="command">Command name, command parameters</param>
        /// <returns>True if succeeded, false otherwise</returns>
        private bool TryToExecuteWithArguments(CarsHouse carsHouse, string command)
        {
            string[] splittedCommand = command.Split(' ');
            command = "";
            for (int i = 0; i < splittedCommand.Length; i++)
            {
                command += splittedCommand[i] + " ";
                if (CommandsDictionary.ContainsKey(command))
                {
                    CommandsDictionary[command].Execute(carsHouse, splittedCommand[i + 1]);
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