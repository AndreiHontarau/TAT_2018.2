using DEV_5.Interfaces;
using DEV_5.Storages;

namespace DEV_5
{
    /// <summary>
    /// Command class of "count types truck" command 
    /// </summary>
    class CountTrucksBrandsCommand : ICommand
    {
        private Storage Storage;

        public CountTrucksBrandsCommand(Storage storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of a Storage object
        /// </summary>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute()
        {
            Storage.CountTrucksBrands();
        }
    }
}