using DEV_5.Interfaces;
using DEV_5.Storages;

namespace DEV_5
{
    /// <summary>
    /// Command class of "count types car" command 
    /// </summary>
    class CountCarsBrandsCommand : ICommand
    {
        private Storage Storage;

        public CountCarsBrandsCommand(Storage storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of a Storage object
        /// </summary>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute()
        {
            Storage.CountCarsBrands();
        }
    }
}