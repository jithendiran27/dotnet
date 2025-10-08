namespace Services;

using Entities;

public interface IOrderService {
    Task<List<Order>> getAllOrders();
    void orderFromCart(Order cartItems);
}