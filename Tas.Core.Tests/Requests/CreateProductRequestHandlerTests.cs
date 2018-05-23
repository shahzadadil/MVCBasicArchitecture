using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System.Threading.Tasks;
using Tas.Core.Requests;
using Tas.Core.Repositories;
using Tas.Data.Entities;
using static Rhino.Mocks.RhinoMocksExtensions;

namespace Tas.Core.Tests.Requests
{
    [TestClass]
    public class CreateProductRequestHandlerTests
    {
        [TestMethod]
        public void can_create_product()
        {
            //// ARRANGE
            var request = new CreateProductRequest("TestName", 12.5, 11);
            var handler = new CreateProductRequestHandler();

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
            var result = handler.ExecuteAsync(request).Result;

            //// ASSERT
            Assert.IsTrue(result.IsSuccessful);
            Assert.IsNull(result.ErrorMessage);
        }
    }
}
