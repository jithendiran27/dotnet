namespace Entities;
using MongoDB.Bson.Serialization.Attributes;

public class ShoppingCart : Product
{
    [BsonElement("quantity")]
    public string quantity {get; set;}

    [BsonElement("items")]
    public List<Product> items {get; set;}
}