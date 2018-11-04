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
