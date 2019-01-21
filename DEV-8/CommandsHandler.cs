using System;
using System.Text;
using System.Collections.Generic;
using DEV_5.Storages;
using  DEV_5.Interfaces;

namespace DEV_5
{
    /// <summary>
    /// Handles command line commands
    /// </summary>
    partial class CommandsHandler
    {
        private List<ICommand> commandsList = new List<ICommand>();

        private static Storage Storage;

        public CommandsHandler(Storage storage)
        {
            Storage = storage;
            CommandsDictionary = new Dictionary<string, ICommand>()
            {
                [Exit] = new ExitCommand(),
                [CountCarsBrands] = new CountCarsBrandsCommand(storage),
                [CountAllCars] = new CountAllCarsCommand(storage),
                [CarAveragePrice] = new CountAverageCarPriceCommand(storage),

                [CountTrucksBrands] = new CountTrucksBrandsCommand(storage),
                [CountAllTrucks] = new CountAllTrucksCommand(storage),
                [TruckAveragePrice] = new CountAverageTruckPriceCommand(storage),
            };

            CommandsWithArgsDictionary = new Dictionary<string, ICommandWithArgument>()
            {
                [CarAveragePriceForBrand] = new CountCarsAveragePriceFotBrandCommand(storage),
                [TruckAveragePriceForBrand] = new CountTrucksAveragePriceFotBrandCommand(storage)
            };
        }

        /// <summary>
        /// Tries to find and execute command from CommandsDictionry
        /// </summary>
        /// <param name="command">Command name, command parameters</param>
        public void HandleCommand(string command)
        {
            if (command != "execute")
            {
                if (CommandsDictionary.ContainsKey(command))
                {
                    commandsList.Add(CommandsDictionary[command]);
                }
                else if (!TryToCreateWithArguments(command))
                {
                    Console.WriteLine("Wrong command.");
                }
            }
            else
            {
                foreach (ICommand Command in commandsList)
                {
                    Command.Execute();
                }
                commandsList.Clear();
            }
        }

        /// <summary>
        /// Tries to find and add to commandsList command with parameter from CommandsDictionry
        /// </summary>
        /// <param name="command">Command name, command parameters</param>
        /// <returns>True if succeeded, false otherwise</returns>
        private bool TryToCreateWithArguments(string command)
        {
            string[] splittedCommand = command.Split(' ');
            command = "";

            for (int i = 0; i < splittedCommand.Length - 1; i++)
            {
                command += splittedCommand[i] + " ";
                if (CommandsWithArgsDictionary.ContainsKey(command))
                {
                    var newCommand =  CommandsWithArgsDictionary[command];
                    newCommand.Argument = splittedCommand[i + 1];
                    commandsList.Add(CommandsWithArgsDictionary[command]);
                    return true;
                }
            }

            return false;
        }

        private void TryToExecute(VehiclesStorage vehiclesStorage, string command)
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