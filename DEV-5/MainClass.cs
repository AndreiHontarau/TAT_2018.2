using System;
using System.Collections.Generic;

namespace DEV_5
{
    /// <summary>
    /// Provides basic functionality
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                CarCreator carCreator = new CarCreator();
                List<Car> CarsList = new List<Car>();
                while (Console.ReadKey(true).Key != ConsoleKey.Escape)
                {
                    CarsList.Add(carCreator.Create());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
