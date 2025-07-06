namespace RetailInventory.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = "";
    public int Stock { get; set; }
    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}
