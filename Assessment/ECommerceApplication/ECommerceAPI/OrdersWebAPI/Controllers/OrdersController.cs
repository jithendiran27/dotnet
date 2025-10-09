using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;

namespace OrdersWebAPI.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    [Route("all")]
    public async Task<IActionResult> getAllOrders()
    {
        return Ok(await _orderService.getAllOrders());
    }

    [HttpPost]
    [Route("addFromCart")]
    public IActionResult addFromCart([FromBody] Order order)
    {
        _orderService.orderFromCart(order);
        return Ok();
    }
}
