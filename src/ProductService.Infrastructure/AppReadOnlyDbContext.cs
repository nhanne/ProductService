using Microsoft.EntityFrameworkCore;
using ProductService.Domain.Entities.Categories;
using ProductService.Domain.Entities.Products;
using ProductService.Domain.Entities.Variants;

namespace ProductService.Infrastructure;

public class AppReadOnlyDbContext : DbContext
{
    public AppReadOnlyDbContext()
    {
    }
    public AppReadOnlyDbContext(DbContextOptions<AppReadOnlyDbContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder opts)
    {
        base.OnConfiguring(opts);
        opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Variant> Variants { get; set; }
}