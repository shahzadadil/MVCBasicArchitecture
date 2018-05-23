namespace Tas.Core.Requests
{
    public interface IRequestResult
    {
        bool IsSuccessful { get; }
        string ErrorMessage { get;}
    }
}
