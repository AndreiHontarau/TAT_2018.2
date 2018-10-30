using System;

namespace DEV_5
{
    /// <summary>
    /// Clss for car creation
    /// </summary>
    class CarCreator
    {
        public Car Create()
        {
            Console.Write("Enter car brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter car model: ");
            string model = Console.ReadLine();

            Console.Write("Enter amount of cars: ");
            int amount = Int32.Parse(Console.ReadLine());

            Console.Write("Enter car price: ");
            float price = Single.Parse(Console.ReadLine());

            return new Car(brand, model, price, amount);
        }
    }
}