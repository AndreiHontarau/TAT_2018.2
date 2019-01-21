namespace DEV_5
{
    /// <summary>
    /// Command class of "average price" command 
    /// </summary>
    class AveragePriceCommand : ICommand
    {
        private CarsHouse Storage;

        public AveragePriceCommand(CarsHouse storage)
        {
            Storage = storage;
        }

        /// <summary>
        /// Calls corresponding method of CarsHouse object
        /// </summary>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute(string additionalParameter = null)
        {
            Storage.CountAveragePrice();
        }
    }
}