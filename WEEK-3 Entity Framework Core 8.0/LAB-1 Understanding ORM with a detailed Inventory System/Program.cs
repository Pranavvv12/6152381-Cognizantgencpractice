using RetailInventory.Data;
using RetailInventory.Models;

using var context = new RetailContext();

if (!context.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    context.Categories.AddRange(electronics, groceries);
    context.Products.AddRange(
        new Product { Name = "Laptop", Stock = 10, Category = electronics },
        new Product { Name = "Apple", Stock = 50, Category = groceries }
    );

    context.SaveChanges();
}

foreach (var product in context.Products.Include(p => p.Category))
{
    Console.WriteLine($"{product.Name} ({product.Category?.Name}) - Stock: {product.Stock}");
}
