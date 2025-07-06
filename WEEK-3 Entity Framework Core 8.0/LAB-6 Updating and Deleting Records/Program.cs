using Microsoft.EntityFrameworkCore;
using RetailStore.Data;
using RetailStore.Models;

var context = new AppDbContext();

var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
if (product != null)
{
    product.Price = 70000;
    await context.SaveChangesAsync();
    Console.WriteLine($"Updated: {product.Name} - ₹{product.Price}");
}
else
{
    Console.WriteLine("Product 'Laptop' not found.");
}

var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
if (toDelete != null)
{
    context.Products.Remove(toDelete);
    await context.SaveChangesAsync();
    Console.WriteLine($"Deleted: {toDelete.Name}");
}
else
{
    Console.WriteLine("Product 'Rice Bag' not found.");
}

Console.WriteLine("\nRemaining Products:");
var products = await context.Products.Include(p => p.Category).ToListAsync();
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price} - Category: {p.Category.Name}");
}
