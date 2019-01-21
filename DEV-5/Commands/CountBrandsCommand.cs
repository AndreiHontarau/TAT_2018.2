namespace DEV_5
{
    /// <summary>
    /// Command class of "count types" command 
    /// </summary>
    class CountBrandsCommand : ICommand
    {
        private CarsHouse Storage;

        public CountBrandsCommand(CarsHouse storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of CarsHouse object
        /// </summary>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute(string additionalParameter = null)
        {
            Storage.CountBrands();
        }
    }
}