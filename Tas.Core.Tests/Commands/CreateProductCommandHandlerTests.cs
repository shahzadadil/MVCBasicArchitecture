using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System.Threading.Tasks;
using Tas.Core.Commands;
using Tas.Core.Repositories;
using Tas.Data.Entities;
using static Rhino.Mocks.RhinoMocksExtensions;

namespace Tas.Core.Tests.Commands
{
    [TestClass]
    public class CreateProductCommandHandlerTests
    {
        [TestMethod]
        public void can_create_product()
        {
            //// ARRANGE
            var command = new CreateProductCommand("TestName", 12.5, 11);
            var handler = new CreateProductCommandHandler();

            var productRepository = MockRepository.GenerateStub<IGenericRepository<Product>>();
            productRepository
                .Expect(repo => repo.SaveAsync())
                .Return(Task.FromResult( 
                    new Product
                    {
                        Id = 12
                    }));

            handler.ProductRepository = productRepository;

            //// ACT
            var result = handler.ExecuteAsync(command).Result;

            //// ASSERT
            Assert.IsTrue(result.IsSuccessful);
            Assert.IsNull(result.ErrorMessage);
        }
    }
}
