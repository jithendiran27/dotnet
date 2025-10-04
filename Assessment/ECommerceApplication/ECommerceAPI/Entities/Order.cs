namespace Entities;

public class Order 
{
    public int id {get; set;}

    public List<ShoppingCart> Items {get; set;}
}