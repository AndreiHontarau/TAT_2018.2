using System;
using System.Collections.Generic;

namespace DEV_5
{
    class CarsHouse
    {
        private List<Car> CarsList;

        public void CreateCar()
        {
            Console.Write("Enter car brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter car model: ");
            string model = Console.ReadLine();

            Console.Write("Enter amount of cars: ");
            int amount = Int32.Parse(Console.ReadLine());

            Console.Write("Enter car price: ");
            float price = Single.Parse(Console.ReadLine());

            CarsList.Add(new Car(brand, model, price, amount));
        }
    }
}