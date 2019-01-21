using DEV_5.Interfaces;
using DEV_5.Storages;

namespace DEV_5
{
    /// <summary>
    /// Command class of "count all car" command 
    /// </summary>
    class CountAllCarsCommand : ICommand
    {
        private Storage Storage;

        public CountAllCarsCommand(Storage storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of a Storage object
        /// </summary>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute()
        {
            Storage.CountAllCars();
        }
    }
}