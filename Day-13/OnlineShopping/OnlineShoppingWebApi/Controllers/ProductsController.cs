namespace OnlineShoppingWebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using ProductCatalogueEntity;
using ProductCatalogueRepo;
using ProductCatalogueService;

[ApiController]
[Route("[controller]")]

public class ProductsController : ControllerBase {

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger) {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Product> Get() {
        IProductRepo productRepo = new ProductRepo();
        IProductService productService = new ProductService(productRepo);

        return productService.getAllProducts();

    }


    
}