using System.Collections.Generic;
using System.Linq;
using DEV_5.Products;
using DEV_5.Interfaces;

namespace DEV_5.Storages
{
    /// <summary>
    /// Stores Vehicle objects in List
    /// </summary>
    class VehiclesStorage : IVehicleStorage
    {
        private List<Vehicle> VehiclesList;

        /// <summary>
        /// Creates VehiclesStorage object and CarsList
        /// </summary>
        public VehiclesStorage(List<Vehicle> list)
        {
            VehiclesList = list;
        }

        public bool IsEmpty()
        {
            if (VehiclesList.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddVehicle(Vehicle newVehicle)
        {
            VehiclesList.Add(newVehicle);
        }

        /// <summary>
        /// Counts and prints amount of brands in VehiclesList
        /// </summary>
        public void CountBrands()
        {
            int brandsCounter = 0;
            List<string> brands = new List<string>();

            foreach (Vehicle vehicle in VehiclesList)
            {
                if (!brands.Contains(vehicle.Brand))
                {
                    brands.Add(vehicle.Brand);
                    brandsCounter++;
                }
            }

            PrintResult(brandsCounter);
        }

        /// <summary>
        /// Counts and prints total amount of cars in VehiclesList
        /// </summary>
        public void CountAllVehicles()
        {
            int amountOfVehicles = 0;

            foreach (Vehicle vehicle in VehiclesList)
            {
                amountOfVehicles += vehicle.Amount;
            }

            PrintResult(amountOfVehicles);
        }

        /// <summary>
        /// Counts and prints average price of a car for all cars in VehiclesList
        /// </summary>
        public void CountAveragePrice()
        {
            float totalPrice = 0;
            float averagePrice;

            foreach (Vehicle vehicle in VehiclesList)
            {
                totalPrice += vehicle.UnitPrice;
            }

            averagePrice = totalPrice / VehiclesList.Count;

            PrintResult(averagePrice);
        }

        /// <summary>
        /// Counts and prints average price of a car for cars of a specified brand in VehiclesList
        /// </summary>
        /// <param name="brand">Brand to count average price for</param>
        public void CountAveragePriceFotBrand(string brand)
        {
            float averagePrice;
            float totalPrice = 0;
            float vehiclesCounter = 0;

            foreach (Vehicle vehicle in VehiclesList)
            {
                if (vehicle.Brand.Equals(brand))
                {
                    totalPrice += vehicle.UnitPrice;
                    vehiclesCounter++;
                }
            }

            averagePrice = totalPrice / vehiclesCounter;

            PrintResult(averagePrice);
        }

        public void PrintResult(float result)
        {
            System.Console.WriteLine(result);
        }
    }
}