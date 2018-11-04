namespace DEV_5
{
    /// <summary>
    /// Command class of "average price %brand%" command 
    /// </summary>
    class AveragePriceForBrandCommand : IExecutable
    {
        /// <summary>
        /// Calls corresponding method of CarsHouse object
        /// </summary>
        /// <param name="carsHouse">CarsHouse object to call method for</param>
        /// <param name="additionalParameter">Brand to count average price for</param>
        public void Execute(CarsHouse carsHouse, string brand)
        {
            carsHouse.CountAveragePriceFotBrand(brand);
        }
    }
}