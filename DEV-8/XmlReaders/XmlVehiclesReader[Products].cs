using System.Collections.Generic;
using DEV_5.Facrories;

namespace DEV_5.XmlReaders
{
    partial class XmlVehiclesReader
    {
        private const string Cars = "Cars";
        private const string Trucks = "Trucks";

        private Dictionary<string, VehicleCreator> FactoriesDictionary = new Dictionary<string, VehicleCreator>()
        {
            [Cars] = new CarCreator(),
            [Trucks] = new TruckCreator()
        };
    }
}
