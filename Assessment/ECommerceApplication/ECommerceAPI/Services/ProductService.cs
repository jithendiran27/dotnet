namespace Services;

using Entities;
using Repositories;

public class ProductService : IProductService
{
    private readonly IProductRepo _productRepo;

    public ProductService(IProductRepo productRepo) {
        _productRepo = productRepo;
    }

    public async Task<List<Product>> getAllProducts() {
        return await _productRepo.getAllProducts();
    }

    public async Task<Product> getProductById(int id) {
        return await _productRepo.getProductById(id);
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
