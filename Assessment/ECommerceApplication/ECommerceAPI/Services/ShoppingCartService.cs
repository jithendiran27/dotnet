namespace Services;

using Entities;
using Repositories;

public class ShoppingCartService : IShoppingCartService
{

    private readonly IShoppingCartRepo _shoppingCartRepo;

    public ShoppingCartService(IShoppingCartRepo shoppingCartRepo) {
        _shoppingCartRepo = shoppingCartRepo;
    }

    public void addToCart(ShoppingCart product) {
        _shoppingCartRepo.addToCart(product);
    }

    public void removeFromCart(ShoppingCart product) {
        _shoppingCartRepo.removeFromCart(product);
    }

    public async Task<List<ShoppingCart>> getAllProductsFromCart() {
        return await _shoppingCartRepo.getAllProductsFromCart();
    }

}
