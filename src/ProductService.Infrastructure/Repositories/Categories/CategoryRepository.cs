using ProductService.Domain.Entities.Categories;

namespace ProductService.Infrastructure.Repositories.Categories;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
}