namespace ProductCatalogueRepo;

using ProductCatalogueEntity;
using System.Collections.Generic;

public class ProductRepo : IProductRepo
{
    public IEnumerable<Product> getAllProducts() {
        return JSONCatalogueManager.GetProductsFromJson();
    }

    public Product getProductById(int id) {
        return getAllProducts().FirstOrDefault(product => product.id == id);
    }

    public void addNewProduct(Product product) {
        List<Product> products = getAllProducts().ToList();
        products.Add(product);

        JSONCatalogueManager.saveProductsInJson(products);
    }

    public void updateProduct(Product product) {
        // Product selectedProduct = getProductById(product.id);
        // List<Product> products = getAllProducts().FirstOrDefault(product => product.id == id);

    }

    public void deleteProductById(int id) {
        List<Product> products = getAllProducts().ToList();
        var product = getProductById(id);
        products.Remove(product);

        JSONCatalogueManager.saveProductsInJson(products);
    }

}
