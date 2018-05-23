namespace Tas.Core.Commands
{
    public interface ICommandResult
    {
        bool IsSuccessful { get; }
        string ErrorMessage { get;}
    }
}
