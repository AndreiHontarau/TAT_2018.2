using System.Collections.Generic;

namespace DEV_5
{
    /// <summary>
    /// Cars storage, stores Car objects in List
    /// </summary>
    class CarsHouse : IStorage
    {
        private List<Product> CarsList;

        /// <summary>
        /// Creates CarsHouse object and CarsList
        /// </summary>
        public CarsHouse()
        {
            CarsList = new List<Product>();
        }

        /// <summary>
        /// Adds Car object to CarsList
        /// </summary>
        /// <param name="newCar">Car to add</param>
        public void AddProduct(Product newCar)
        {
            CarsList.Add(newCar);
        }

        /// <summary>
        /// Counts and prints amount of brands in CarsList
        /// </summary>
        public void CountBrands()
        {
            int brandsCounter = 0;
            List<string> brands = new List<string>();

            foreach (Car car in CarsList)
            {
                if (!brands.Contains(car.Brand))
                {
                    brands.Add(car.Brand);
                    brandsCounter++;
                }
            }

            System.Console.WriteLine(brandsCounter);
        }

        /// <summary>
        /// Counts and prints total amount of cars in CarsList
        /// </summary>
        public void CountAllProducts()
        {
            int amountOfCars = 0;

            foreach (Car car in CarsList)
            {
                amountOfCars += car.Amount;
            }

            System.Console.WriteLine(amountOfCars);
        }

        /// <summary>
        /// Counts and prints average price of a car for all cars in CarsList
        /// </summary>
        public void CountAveragePrice()
        {
            float totalPrice = 0;
            float averagePrice;

            foreach (Car car in CarsList)
            {
                totalPrice += car.Price;
            }

            averagePrice = totalPrice / CarsList.Count;

            System.Console.WriteLine(averagePrice);
        }

        /// <summary>
        /// Counts and prints average price of a car for cars of a specified brand in CarsList
        /// </summary>
        /// <param name="brand">Brand to count average price for</param>
        public void CountAveragePriceFotBrand(string brand)
        {
            float totalPrice = 0;
            float averagePrice;
            float carsCounter = 0;

            foreach (Car car in CarsList)
            {
                if (car.Brand.Equals(brand))
                {
                    totalPrice += car.Price;
                    carsCounter++;
                }
            }

            averagePrice = totalPrice / carsCounter;

            System.Console.WriteLine(averagePrice);
        }
    }
}