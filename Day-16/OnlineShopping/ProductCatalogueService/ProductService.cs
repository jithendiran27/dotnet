namespace ProductCatalogueService;

using ProductCatalogueEntity;
using ProductCatalogueRepo;
using System.Collections.Generic;

public class ProductService : IProductService
{
    private readonly IProductRepo _productRepo;

    public ProductService(IProductRepo productRepo) {
        _productRepo = productRepo;
    }

    public IEnumerable<Product> getAllProducts() {
        return _productRepo.getAllProducts();
    }

    public Product getProductById(int id) {
        return _productRepo.getProductById(id);
    }

    public void addNewProduct(Product product) {
        _productRepo.addNewProduct(product);
    }

    public void updateProduct(Product product) {
        _productRepo.updateProduct(product);
    }

    public void deleteProductById(int id) {
        _productRepo.deleteProductById(id);
    }

}
