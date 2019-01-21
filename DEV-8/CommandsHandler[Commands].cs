using System.Collections.Generic;
using DEV_5.Interfaces;

namespace DEV_5
{
    partial class CommandsHandler
    {
        // Possible commands
        private const string Exit = "exit";

        private const string CountCarsBrands = "count types car";
        private const string CountAllCars = "count all car";
        private const string CarAveragePrice = "average price car";
        private const string CarAveragePriceForBrand = "average price car ";

        private const string CountTrucksBrands = "count types truck";
        private const string CountAllTrucks = "count all truck";
        private const string TruckAveragePrice = "average price truck";
        private const string TruckAveragePriceForBrand = "average price truck ";

        private Dictionary<string, ICommand> CommandsDictionary;

        private Dictionary<string, ICommandWithArgument> CommandsWithArgsDictionary;
    }
}
