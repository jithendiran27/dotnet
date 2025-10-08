namespace Repositories;

using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

public class ProductRepo : IProductRepo {

    private readonly IMongoCollection<Product> _productCollection;

    public ProductRepo(string connectionString, string databaseName, string collectionName) {
        var mongoClient = new MongoClient(connectionString);
        var database = mongoClient.GetDatabase(databaseName);
        _productCollection = database.GetCollection<Product>(collectionName);
    }

    public async Task<List<Product>> getAllProducts() {
        var result = _productCollection.Find(p => true).ToList();;
        return await Task.FromResult(result);
    }

    public async Task<Product> getProductById(int id) {
        var result = _productCollection.Find(p => p.id == id).FirstOrDefault();
        return await Task.FromResult(result);
    }

    public void addNewProduct(Product product) {
        _productCollection.InsertOne(product);
    }

    public void updateProduct(Product product) {
        _productCollection.ReplaceOne(p => p.id == product.id, product);
    }

    public void deleteProductById(int id) {
        _productCollection.DeleteOne(p => p.id == id);
    }
    
}