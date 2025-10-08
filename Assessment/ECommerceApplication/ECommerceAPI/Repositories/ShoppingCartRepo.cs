namespace Repositories;

using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

public class ShoppingCartRepo : IShoppingCartRepo {

    private readonly IMongoCollection<ShoppingCart> _shoppingCartCollection;

    public ShoppingCartRepo(string connectionString, string databaseName, string collectionName) {
        var mongoClient = new MongoClient(connectionString);
        var database = mongoClient.GetDatabase(databaseName);
        _shoppingCartCollection = database.GetCollection<ShoppingCart>(collectionName);
    }

    public void addToCart(ShoppingCart product) {
        _shoppingCartCollection.InsertOne(product);
    }
    
    public void removeFromCart(ShoppingCart product) {
        _shoppingCartCollection.DeleteOne(p => p.id == product.id);
    }

    public async Task<List<ShoppingCart>> getAllProductsFromCart() {
        var result = _shoppingCartCollection.Find(p => true).ToList();;
        return await Task.FromResult(result);
    }
}