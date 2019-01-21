namespace DEV_5
{
    /// <summary>
    /// Provides basic functionality of the program
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Entry point
        /// </summary>
        static void Main()
        {
            try
            {
                CarsHouse carsHouse = new CarsHouse();
                CarsHouseMenu Menu = CarsHouseMenu.getMenu();
                Menu.Interact(carsHouse);
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
