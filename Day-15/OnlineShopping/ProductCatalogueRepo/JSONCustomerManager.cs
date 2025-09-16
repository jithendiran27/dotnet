namespace ProductCatalogueRepo;

using ProductCatalogueEntity;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class JSONCustomerManager {

    public static string customersJSONPath = @"C:\WORKSPACE\Training\DotNet\Solutions\dotnet\Day-15\OnlineShopping\ProductCatalogueRepo\Data\Customers.json";

    public static IEnumerable<Customer> GetCustomersFromJson() {
        var jsonFile = File.ReadAllText(customersJSONPath);
        return JsonSerializer.Deserialize<IEnumerable<Customer>>(jsonFile);
    }

    public static void addCustomersInJson(IEnumerable<Customer> Customers) {
        var jsonFile = JsonSerializer.Serialize(Customers);
        File.WriteAllText(customersJSONPath, jsonFile);
    }
}