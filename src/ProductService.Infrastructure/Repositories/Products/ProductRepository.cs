using ProductService.Domain.Entities.Products;

namespace ProductService.Infrastructure.Repositories.Products;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }
}