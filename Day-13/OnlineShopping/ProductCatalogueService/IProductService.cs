namespace ProductCatalogueService;

using ProductCatalogueEntity;
using System.Collections.Generic;

public interface IProductService
{
    IEnumerable<Product> getAllProducts();

    Product getProductById();

    void addNewProduct(Product product);

    void updateProduct(Product product);

    void deleteProductById(int id);

}
