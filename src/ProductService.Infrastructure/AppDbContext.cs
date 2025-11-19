using Microsoft.EntityFrameworkCore;
using ProductService.Domain.Entities.Categories;
using ProductService.Domain.Entities.Products;
using ProductService.Domain.Exceptions.Variants;

namespace ProductService.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Variant> Variants { get; set; }
}
