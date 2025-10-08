namespace Repositories;

using Entities;

public interface IProductRepo {
    
    Task<List<Product>> getAllProducts();
    Task<Product> getProductById(int id);
    void addNewProduct(Product product);
    void updateProduct(Product product);
    void deleteProductById(int id);
}