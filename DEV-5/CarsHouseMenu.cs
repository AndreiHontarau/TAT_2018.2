using System;

namespace DEV_5
{
    /// <summary>
    /// Allows user to interact with the program,
    /// provides text UI for it
    /// </summary>
    class CarsHouseMenu
    {
        private static CarsHouseMenu Menu;

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

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                carsHouse.AddCar();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Initiates interaction with user through text UI
        /// </summary>
        public void Interact(CarsHouse carsHouse)
        {
            Menu.FillInCarsList(carsHouse);

            CommandsHandler commandsHandler = new CommandsHandler();

            Console.WriteLine("Press any key to enter a command and Esc to stop.");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                commandsHandler.HandleCommand(carsHouse, Console.ReadLine());
            }
        }
    }
}