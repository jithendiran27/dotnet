using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;

namespace ShoppingCartWebAPI.Controllers;

[ApiController]
[Route("api/cart")]
public class ShoppingCartController : ControllerBase
{

    private readonly IShoppingCartService _shoppingCartService;

    public ShoppingCartController(IShoppingCartService shoppingCartService)
    {
        _shoppingCartService = shoppingCartService;
    }

    [HttpGet]
    [Route("all")]
    public async Task<IActionResult> getAllProductsFromCart()
    {
        return Ok(await _shoppingCartService.getAllProductsFromCart());
    }

    [HttpPost]
    [Route("add")]
    public IActionResult addToCart([FromBody] ShoppingCart product)
    {
        _shoppingCartService.addToCart(product);
        return Ok();
    }

    [HttpDelete]
    [Route("remove")]
    public IActionResult removeFromCart(ShoppingCart product)
    {
        _shoppingCartService.removeFromCart(product);
        return Ok();
    }
}
