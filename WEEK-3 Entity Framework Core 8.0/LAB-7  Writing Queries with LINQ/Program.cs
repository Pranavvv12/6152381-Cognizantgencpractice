using Microsoft.EntityFrameworkCore;
using RetailStore.Data;
using RetailStore.Models;

var context = new AppDbContext();

var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

Console.WriteLine("Filtered & Sorted Products (Price > 1000):");
foreach (var p in filtered)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

Console.WriteLine(); 
var productDTOs = await context.Products
    .Select(p => new { p.Name, p.Price })
    .ToListAsync();

Console.WriteLine("Product DTOs (Name & Price):");
foreach (var dto in productDTOs)
{
    Console.WriteLine($"{dto.Name} - ₹{dto.Price}");
}
