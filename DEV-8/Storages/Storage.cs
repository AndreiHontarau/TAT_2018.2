using System.Collections.Generic;
using DEV_5.Products;

namespace DEV_5.Storages
{
    class Storage
    {
        private VehiclesStorage carsStorage;
        private VehiclesStorage trucksStorage;

        public void AddVehicles(List<Vehicle> list)
        {
            if (list[0] is Car)
            {
                if (carsStorage == null)
                {
                    carsStorage = new VehiclesStorage(list);
                }
            }
            else if (list[0] is Truck)
            {
                if (trucksStorage == null)
                {
                    trucksStorage = new VehiclesStorage(list);
                }
            }
        }

        public void CountCarsBrands()
        {
            carsStorage.CountBrands();
        }

        public void CountAllCars()
        {
            carsStorage.CountAllVehicles();
        }

        public void CountAverageCarPrice()
        {
            carsStorage.CountAveragePrice();
        }

        public void CountCarsAveragePriceFotBrand(string brand)
        {
            carsStorage.CountAveragePriceFotBrand(brand);
        }

        public void CountTrucksBrands()
        {
            trucksStorage.CountBrands();
        }

        public void CountAllTrucks()
        {
            trucksStorage.CountAllVehicles();
        }

        public void CountAverageTruckPrice()
        {
            trucksStorage.CountAveragePrice();
        }

        public void CountTrucksAveragePriceFotBrand(string brand)
        {
            trucksStorage.CountAveragePriceFotBrand(brand);
        }
    }
}
