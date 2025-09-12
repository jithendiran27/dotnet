namespace ProductCatalogueRepo;

using ProductCatalogueEntity;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public static class JSONCatalogueManager {

    public static string productsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "products.json");

    public static IEnumerable<Product> GetProductsFromJson() {
        var jsonFile = File.ReadAllText(productsFilePath);
        return JsonSerializer.Deserialize<IEnumerable<Product>>(jsonFile);
    }

    public static void saveProductsInJson(IEnumerable<Product> products) {
        var jsonFile = JsonSerializer.Serialize(products);
        File.WriteAllText(productsFilePath, jsonFile);
    }
}