using DEV_5.XmlReaders;
using DEV_5.Storages;

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
                XmlVehiclesReader reader = XmlVehiclesReader.GetInstance();
                Storage storage = new Storage();
                Menu menu = Menu.GetInstance();
                menu.Invoke(storage, reader);
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
