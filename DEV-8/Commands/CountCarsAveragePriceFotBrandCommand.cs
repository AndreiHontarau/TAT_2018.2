using DEV_5.Interfaces;
using DEV_5.Storages;

namespace DEV_5
{
    /// <summary>
    /// Command class of "average price car %brand%" command 
    /// </summary>
    class CountCarsAveragePriceFotBrandCommand : ICommandWithArgument
    {
        public string Argument { get; set; }

        private Storage Storage;

        public CountCarsAveragePriceFotBrandCommand(Storage storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of a Storage object
        /// </summary>
        /// <param name="additionalParameter">Brand to count average price for</param>
        public void Execute()
        {
            Storage.CountCarsAveragePriceFotBrand(Argument);
        }
    }
}