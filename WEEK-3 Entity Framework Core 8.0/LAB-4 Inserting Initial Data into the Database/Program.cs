using Microsoft.EntityFrameworkCore;
using RetailStore.Data;
using RetailStore.Models;

var context = new AppDbContext();

await context.Database.EnsureDeletedAsync();
await context.Database.EnsureCreatedAsync();

var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

await context.Categories.AddRangeAsync(electronics, groceries);

var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

await context.Products.AddRangeAsync(product1, product2);
await context.SaveChangesAsync();

Console.WriteLine("Product List:\n");

var products = await context.Products.Include(p => p.Category).ToListAsync();
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price} - Category: {p.Category.Name}");
}
