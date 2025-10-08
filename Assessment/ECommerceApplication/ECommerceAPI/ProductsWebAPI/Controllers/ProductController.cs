using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;

namespace ProductsWebAPI.Controllers;

[ApiController]
[Route("api/catalogue")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    [Route("products")]
    public async Task<IActionResult> getAllProducts()
    {
        return Ok(await _productService.getAllProducts());
    }

    [HttpGet]
    [Route("getProductById")]
    public async Task<IActionResult> getProductById(int id)
    {
        return Ok(await _productService.getProductById(id));
    }

    [HttpPost]
    [Route("addNewProduct")]
    public IActionResult addNewProduct([FromBody] Product product)
    {
        _productService.addNewProduct(product);
        return Ok();
    }

    [HttpPut]
    [Route("updateProduct")]
    public IActionResult updateProduct([FromBody] Product product)
    {
        _productService.updateProduct(product);
        return Ok();
    }

    [HttpDelete]
    [Route("deleteProductById")]
    public IActionResult deleteProductById(int id)
    {
        _productService.deleteProductById(id);
        return Ok();
    }

}
