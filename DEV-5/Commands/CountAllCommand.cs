namespace DEV_5
{
    /// <summary>
    /// Command class of "count all" command 
    /// </summary>
    class CountAllCommand : ICommand
    {
        private CarsHouse Storage;

        public CountAllCommand(CarsHouse storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of CarsHouse object
        /// </summary>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute(string additionalParameter = null)
        {
            Storage.CountAllProducts();
        }
    }
}