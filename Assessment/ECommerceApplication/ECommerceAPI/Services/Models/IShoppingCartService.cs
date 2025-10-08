namespace Services;

using Entities;

public interface IShoppingCartService {
    void addToCart(ShoppingCart product);
    void removeFromCart(ShoppingCart product);
    Task<List<ShoppingCart>> getAllProductsFromCart();
}