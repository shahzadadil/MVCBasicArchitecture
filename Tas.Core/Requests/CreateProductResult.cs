namespace Tas.Core.Requests
{
    public class CreateProductResult : RequestResultBase
    {
        public CreateProductResult(
            int productId, 
            bool isSuccessful = true, 
            string errorMessage = null) : base(isSuccessful, errorMessage)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        public override string ToString()
        {
            return IsSuccessful
                ? $"Successfully Created Product Id: {ProductId}"
                : $"Error creating product: {ErrorMessage}";
        }
    }
}
