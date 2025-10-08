namespace Services;

using Entities;
using Repositories;

public class OrderService : IOrderService {

    private readonly IOrderRepo _ordersRepo;

    public OrderService(IOrderRepo ordersRepo) {
        _ordersRepo = ordersRepo;
    }

    public async Task<List<Order>> getAllOrders() {
        return await _ordersRepo.getAllOrders();
    }

    public void orderFromCart(Order cartItems) {
        _ordersRepo.orderFromCart(cartItems);
    }
}