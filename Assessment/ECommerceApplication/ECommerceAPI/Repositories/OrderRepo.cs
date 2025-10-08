namespace Repositories;

using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

public class OrderRepo : IOrderRepo {

    private readonly IMongoCollection<Order> _orderCollection;

    public OrderRepo(string connectionString, string databaseName, string collectionName) {
        var mongoClient = new MongoClient(connectionString);
        var database = mongoClient.GetDatabase(databaseName);
        _orderCollection = database.GetCollection<Order>(collectionName);
    }
    
    public async Task<List<Order>> getAllOrders() {
        var result = _orderCollection.Find(p => true).ToList();;
        return await Task.FromResult(result);
    }

    public void orderFromCart(Order cartItems) {
        _orderCollection.InsertOne(cartItems);
    }
}