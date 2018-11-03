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
            if (getMenu() == null)
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
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                carsHouse.CreateCar();
            }
        }

        /// <summary>
        /// Initiates interaction with user through text UI
        /// </summary>
        public void StartInteraction(CarsHouse carsHouse)
        {
            Menu.FillInCarsList(carsHouse);
        }
    }
}