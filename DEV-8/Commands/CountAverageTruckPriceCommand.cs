using DEV_5.Interfaces;
using DEV_5.Storages;

namespace DEV_5
{
    /// <summary>
    /// Command class of "average price truck" command 
    /// </summary>
    class CountAverageTruckPriceCommand : ICommand
    {
        private Storage Storage;

        public CountAverageTruckPriceCommand(Storage storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of a Storage object
        /// </summary>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute()
        {
            Storage.CountAverageTruckPrice();
        }
    }
}
