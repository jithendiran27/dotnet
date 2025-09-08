namespace ServicesLib;
using RepositoryLib;
using EntitiesLib;

public class ProductService
{

    private readonly ProductsRepo _productRepo;

    public ProductService (ProductsRepo productRepo) {
        _productRepo = productRepo;
    }

    public List<Product> GetAllProducts() {
        return _productRepo.GetAllProducts();
    }

    public void AddNewProduct(Product product) {
        _productRepo.AddNewProduct(product);
    }

    public void DeleteProduct(int id) {
        _productRepo.DeleteProduct(id);
    }

    public void UpdateProduct(Product product) {
        _productRepo.UpdateProduct(product);
    }

}
