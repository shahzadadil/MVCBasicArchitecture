using System;
using System.Threading.Tasks;
using Tas.Core.Repositories;
using Tas.Data.Entities;

namespace Tas.Core.Commands
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public IGenericRepository<Product> ProductRepository { get; set; }

        public async Task<CreateProductResult> ExecuteAsync(CreateProductCommand command)
        {
            var username = command.Username;
            var time = DateTime.UtcNow;

            var product = new Product
            {
                Name = command.Name,
                Price = command.Price,
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
