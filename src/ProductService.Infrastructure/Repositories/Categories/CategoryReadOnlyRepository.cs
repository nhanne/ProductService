using Microsoft.EntityFrameworkCore;
using ProductService.Common.Filters;
using ProductService.Common.Wrappers;
using ProductService.Domain.Entities.Categories;
using ProductService.Infrastructure.Helpers;

namespace ProductService.Infrastructure.Repositories.Categories;

public class CategoryReadOnlyRepository : ReadOnlyRepository<Category>, ICategoryReadOnlyRepository
{
    public CategoryReadOnlyRepository(AppReadOnlyDbContext context) : base(context)
    {

    }
    public async Task<Category?> FindByCodeAsync(string code)
    {
        return await Queryable.FirstOrDefaultAsync(x => x.Code == code);
    }
    public async Task<Category?> FindByNameAsync(string name)
    {
        return await Queryable.FirstOrDefaultAsync(x => x.Name == name);
    }

    public async Task<PagedResponse<List<Category>>> GetPageAsync(PaginationFilter pageFilter)
    {
        return await Queryable.ToPagedResponseListAsync(pageFilter);
    }
}