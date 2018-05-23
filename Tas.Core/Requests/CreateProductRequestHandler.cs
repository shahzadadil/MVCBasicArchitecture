using System;
using System.Threading.Tasks;
using Tas.Core.Repositories;
using Tas.Data.Entities;

namespace Tas.Core.Requests
{
    public class CreateProductRequestHandler : IRequestHandler<CreateProductRequest, CreateProductResult>
    {
        public IGenericRepository<Product> ProductRepository { get; set; }

        public async Task<CreateProductResult> ExecuteAsync(CreateProductRequest request)
        {
            var username = request.Username;
            var time = DateTime.UtcNow;

            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                CreatedBy = username,
                ModifiedBy = username,
                CreatedOn = time,
                ModifiedOn = time
            };

            ProductRepository.Add(product);
            await ProductRepository.SaveAsync();

            return new CreateProductResult(product.Id);
        }
    }
}
