using DEV_5.Interfaces;
using DEV_5.Storages;

namespace DEV_5
{
    /// <summary>
    /// Command class of "average price truck %brand%" command 
    /// </summary>
    class CountTrucksAveragePriceFotBrandCommand : ICommandWithArgument
    {
        public string Argument { get; set; }

        private Storage Storage;

        public CountTrucksAveragePriceFotBrandCommand(Storage storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of a Storage object
        /// </summary>
        /// <param name="additionalParameter">Brand to count average price for</param>
        public void Execute()
        {
            Storage.CountTrucksAveragePriceFotBrand(Argument);
        }
    }
}