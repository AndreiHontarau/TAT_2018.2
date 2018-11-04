using System;

namespace DEV_5
{
    class CarCreator : ProductCreator
    {
        public override Product Create()
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