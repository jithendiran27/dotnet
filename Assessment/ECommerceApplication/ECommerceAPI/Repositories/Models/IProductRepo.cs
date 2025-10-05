namespace Repositories;

using Entities;

public interface IProductRepo
{
    IEnumerable<Product> getAllProducts();
    Product getProductById(int id);
    void addNewProduct(Product product);
    void updateProduct(Product product);
    void deleteProductById(int id);
}