using System.Threading.Tasks;

namespace Tas.Core.Requests
{
    public interface IRequestHandler<TRequest, TResult>
        where TRequest: IRequest where TResult: IRequestResult
    {
        Task<TResult> ExecuteAsync(TRequest request);
    }
}
