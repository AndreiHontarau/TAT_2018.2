using DEV_5.Interfaces;

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
        /// <param name="additionalParameter">Not used for this command</param>
        public void Execute()
        {
            Menu.GetInstance().Exit();
        }
    }
}