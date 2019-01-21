namespace DEV_5
{
    /// <summary>
    /// Command class of "exit" command 
    /// </summary>
    class ExitCommand : ICommand
    {
        /// <summary>
        /// Calls Exit() for Menu
        /// </summary>
        /// <param name="carsHouse">Not used for this command</param>
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute(string additionalParameter = null)
        {
            CarsHouseMenu.getMenu().Exit();
        }
    }
}