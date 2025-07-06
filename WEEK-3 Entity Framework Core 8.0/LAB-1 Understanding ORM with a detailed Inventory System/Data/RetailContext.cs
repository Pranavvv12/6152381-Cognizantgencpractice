using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory.Data;

public class RetailContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RetailInventoryDB;Trusted_Connection=True;");
}
