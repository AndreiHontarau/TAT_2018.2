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
        private const string AveragePriceForBrand = "average price 'brand'";

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
        /// Decides wich command to execute
        /// </summary>
        /// <param name="CarsList">List of cars that must be passed to command</param>
        /// <param name="command">Command name</param>
        public void HandleCommand(List<Car> CarsList, string command)
        {
            if (CommandsDictionary.ContainsKey(command))
            {
                CommandsDictionary[command].Execute(CarsList, ExtractCommandParameter(command));
            }
            else
            {
                Console.WriteLine("Wrong command. For help enter \"help\".");
            }
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