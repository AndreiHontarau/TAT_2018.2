using System;

namespace DEV_5
{
    /// <summary>
    /// Class for cars creation
    /// </summary>
    class CarCreator : ProductCreator
    {
        /// <summary>
        /// Leads user through steps of car creation,
        /// creates an object of Car class
        /// </summary>
        /// <returns>Created Car object</returns>
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