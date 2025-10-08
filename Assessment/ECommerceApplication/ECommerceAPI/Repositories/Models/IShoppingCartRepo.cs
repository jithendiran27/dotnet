namespace Repositories;

using Entities;

public interface IShoppingCartRepo {
    void addToCart(ShoppingCart product);
    void removeFromCart(ShoppingCart product);
    Task<List<ShoppingCart>> getAllProductsFromCart();
}