using Microsoft.AspNetCore.Mvc;
using ServicesLib;
using RepositoryLib;
using EntitiesLib;

namespace ECommerceWebApi.controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductsController : ControllerBase {

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger) {
            _logger = logger;
        }

        [HttpGet]

        public List<Product> Get() {

            var productRepository = new ProductsRepo();
            productRepository.Products();
            var productService = new ProductService(productRepository);

            return productService.GetAllProducts();
        }
    }
}