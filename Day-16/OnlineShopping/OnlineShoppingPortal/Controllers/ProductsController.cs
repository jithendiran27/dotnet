namespace OnlineShoppingPortal.Controllers;

using ProductCatalogueEntity;
using ProductCatalogueService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

public class ProductsController: Controller {
    private readonly IProductService _productService;

    public ProductsController(IProductService productService) {
        _productService = productService;
    }

    [Authorize]
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