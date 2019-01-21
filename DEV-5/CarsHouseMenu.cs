using System;

namespace DEV_5
{
    /// <summary>
    /// Allows user to interact with the program,
    /// provides text UI for it. Singleton.
    /// </summary>
    class CarsHouseMenu
    {
        private static CarsHouseMenu Menu;
        private static bool exitFlag = false;

        /// <summary>
        /// Creates an empty CarsHouseMenu object
        /// </summary>
        private CarsHouseMenu() {}

        /// <summary>
        /// Returns CarsHouseMenu singleton object 
        /// </summary>
        /// <returns>Menu</returns>
        public static CarsHouseMenu getMenu()
        {
            if (Menu == null)
            {
                Menu = new CarsHouseMenu();
            }

            return Menu;
        }

        /// <summary>
        /// Allows user to fill in cars list in an instance of CarsHouse class,
        /// provides text UI for it
        /// </summary>
        private void FillInCarsList(CarsHouse carsHouse)
        {
            Console.WriteLine("Press any key to create a car and Esc to stop.");

            CarCreator carCreator = new CarCreator();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Car newCar = (Car)carCreator.Create();
                carsHouse.AddProduct(newCar);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Initiates interaction with user through text UI
        /// </summary>
        public void Interact(CarsHouse carsHouse)
        {
            Menu.FillInCarsList(carsHouse);

            CommandsHandler commandsHandler = new CommandsHandler(carsHouse);

            while (exitFlag != true)
            {
                commandsHandler.HandleCommand(Console.ReadLine());
            }
        }

        /// <summary>
        /// Sets exit flag in true
        /// </summary>
        public void Exit()
        {
            exitFlag = true;
        }
    }
}