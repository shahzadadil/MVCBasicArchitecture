namespace Tas.Core.Requests
{
    public class RequestResultBase : IRequestResult
    {
        public RequestResultBase(bool isSuccessful = false, string errorMessage = null)
        {
            IsSuccessful = isSuccessful;
            ErrorMessage = errorMessage;
        }

        public bool IsSuccessful { get; private set; }
        public string ErrorMessage { get; private set; }
    }
}
