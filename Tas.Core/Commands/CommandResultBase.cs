namespace Tas.Core.Commands
{
    public class CommandResultBase : ICommandResult
    {
        public CommandResultBase(bool isSuccessful = false, string errorMessage = null)
        {
            IsSuccessful = isSuccessful;
            ErrorMessage = errorMessage;
        }

        public bool IsSuccessful { get; private set; }
        public string ErrorMessage { get; private set; }
    }
}
