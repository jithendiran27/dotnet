namespace ProductCatalogueService;

using ProductCatalogueEntity;
using ProductCatalogueRepo;
using System.Collections.Generic;

public class ProductService : IProductService
{
    IEnumerable<Product> getAllProducts();

    Product getProductById();

    void addNewProduct(Product product);

    void updateProduct(Product product);

    void deleteProductById(int id);

}
