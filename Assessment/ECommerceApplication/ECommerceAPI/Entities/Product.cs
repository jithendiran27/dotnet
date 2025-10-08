namespace Entities;
using MongoDB.Bson.Serialization.Attributes;

public class Product
{
    [BsonElement("id")]
    public int id {get; set;}

    [BsonElement("name")]
    public string name {get; set;}

    [BsonElement("price")]
    public decimal price {get; set;}

    [BsonElement("description")]
    public string description {get; set;}

}
