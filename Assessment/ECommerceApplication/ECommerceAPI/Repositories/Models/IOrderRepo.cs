namespace Repositories;

using Entities;

public interface IOrderRepo {
    Task<List<Order>> getAllOrders();
    void orderFromCart(Order cartItems);
}