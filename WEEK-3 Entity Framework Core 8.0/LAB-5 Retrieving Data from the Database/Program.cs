using Microsoft.EntityFrameworkCore;
using RetailStore.Data;
using RetailStore.Models;

var context = new AppDbContext();

var products = await context.Products.ToListAsync();
Console.WriteLine("All Products:");
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

Console.WriteLine(); 
var product = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {product?.Name}");
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive: {expensive?.Name}");
