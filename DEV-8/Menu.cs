using System;
using DEV_5.Storages;
using DEV_5.XmlReaders;

namespace DEV_5
{
    /// <summary>
    /// Allows user to interact with the program,
    /// provides text UI for it. Singleton.
    /// </summary>
    class Menu
    {
        private static Menu menu;
        private static bool exitFlag = false;

        /// <summary>
        /// Creates an empty Menu object
        /// </summary>
        private Menu() {}

        /// <summary>
        /// Returns Menu singleton object 
        /// </summary>
        /// <returns>An instance of Menu</returns>
        public static Menu GetInstance()
        {
            if (menu == null)
            {
                menu = new Menu();
            }

            return menu;
        }

        /// <summary>
        /// Initiates interaction with user through text UI
        /// </summary>
        public void Invoke(Storage Storage, XmlVehiclesReader VehiclesReader)
        {
            CommandsHandler commandsHandler = new CommandsHandler(Storage);

            Console.WriteLine("Press any key to enter path of an XML File to read and Esc to stop.");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                string xmlPath = Console.ReadLine();
                Storage.AddVehicles(VehiclesReader.ReadVehicles(xmlPath));
            }

            while (exitFlag != true)
            {
                Console.WriteLine("Enter a command: ");
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