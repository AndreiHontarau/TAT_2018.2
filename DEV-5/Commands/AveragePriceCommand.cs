namespace DEV_5
{
    /// <summary>
    /// Command class of "average price" command 
    /// </summary>
    class AveragePriceCommand : IExecutable
    {
        /// <summary>
        /// Calls corresponding method of CarsHouse object
        /// </summary>
        /// <param name="carsHouse">CarsHouse object to call method for</param>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute(CarsHouse carsHouse, string additionalParameter = null)
        {
            carsHouse.CountAveragePrice();
        }
    }
}