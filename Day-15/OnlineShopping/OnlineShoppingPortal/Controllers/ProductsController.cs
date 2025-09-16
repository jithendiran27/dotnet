namespace OnlineShoppingPortal.Controllers;

using ProductCatalogueEntity;
using ProductCatalogueService;
using Microsoft.AspNetCore.Mvc;

public class ProductsController: Controller {
    private readonly IProductService _productService;

    public ProductsController(IProductService productService) {
        _productService = productService;
    }

    public IActionResult Index() {
        var products = _productService.getAllProducts();

        return View(products);
    }

    public IActionResult ProductDetails(int id) {
        var product = _productService.getProductById(id);
        ViewData["selectedProduct"] = product;

        return View();
    }
}