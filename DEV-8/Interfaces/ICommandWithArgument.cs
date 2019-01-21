namespace DEV_5.Interfaces
{
    interface ICommandWithArgument : ICommand
    {
        string Argument { get; set; }
    }
}
