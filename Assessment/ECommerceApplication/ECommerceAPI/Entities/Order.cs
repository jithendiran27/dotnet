namespace Entities;
using MongoDB.Bson.Serialization.Attributes;

public class Order 
{
    [BsonElement("id")]
    public int id {get; set;}

    [BsonElement("items")]
    public List<ShoppingCart> items {get; set;}
}