using System.Threading.Tasks;

namespace Tas.Core.Commands
{
    public interface ICommandHandler<TCommand, TResult>
        where TCommand: ICommand where TResult: ICommandResult
    {
        Task<TResult> ExecuteAsync(TCommand command);
    }
}
