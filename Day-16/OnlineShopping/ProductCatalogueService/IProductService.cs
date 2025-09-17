namespace ProductCatalogueService;

using ProductCatalogueEntity;
using System.Collections.Generic;

public interface IProductService
{
    IEnumerable<Product> getAllProducts();

    Product getProductById(int id);

    void addNewProduct(Product product);

    void updateProduct(Product product);

    void deleteProductById(int id);

}
