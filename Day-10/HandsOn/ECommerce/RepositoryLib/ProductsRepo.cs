using EntitiesLib;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace RepositoryLib;

public class ProductsRepo: Product
{
    private readonly List<Product> _products = new List<Product>();

    public void Products() {
        _products.Add(new Product{id = 1, name = "Laptop", price = 30000, description = "HP Laptop with Intel i5 processor"});
        _products.Add(new Product{id = 2, name = "Mobile", price = 10000, description = "Oneplus 7"});
        _products.Add(new Product{id = 3, name = "TV", price = 50000, description = "Sony TV"});
        _products.Add(new Product{id = 4, name = "Dishwasher", price = 20000, description = "BOSCH"});
    }

    public List<Product> GetAllProducts() {
        string path = @"C:\WORKSPACE\Training\DotNet\Day-6\ECommerce\RepositoryLib\Products.json";
        string productsJsonFile = File.ReadAllText(path);
        List<Product> serializedProductsJson = JsonSerializer.Deserialize<List<Product>>(productsJsonFile);

        return serializedProductsJson;
    }

    public void AddNewProduct(Product product) {
        _products.Add(product);
    }

    public Product GetProductByID(int id) {
        return _products.FirstOrDefault(product => product.id == id);
    }

    public void DeleteProduct(int id) {
        // Product selectedProduct = GetProductByID(id);
        _products.Remove(GetProductByID(id));
    }

    public void UpdateProduct(Product product) {
        var selectedProduct = GetProductByID(product.id);

        if(selectedProduct != null) {
            selectedProduct.name = product.name;
            selectedProduct.price = product.price;
            selectedProduct.description = product.description;
        }
    }

}
