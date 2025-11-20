using Microsoft.EntityFrameworkCore;
using ProductService.Common.Filters;
using ProductService.Common.Wrappers;
using ProductService.Domain.Entities.Products;
using ProductService.Infrastructure.Helpers;

namespace ProductService.Infrastructure.Repositories.Products;

public class ProductReadOnlyRepository : ReadOnlyRepository<Product>, IProductReadOnlyRepository
{
    public ProductReadOnlyRepository(AppReadOnlyDbContext context) : base(context)
    {

    }
    public async Task<Product?> FindByCodeAsync(string code)
    {
        return await Queryable.FirstOrDefaultAsync(x => x.Code == code);
    }
    public async Task<Product?> FindByNameAsync(string name)
    {
        return await Queryable.FirstOrDefaultAsync(x => x.Name == name);
    }

    public async Task<PagedResponse<List<Product>>> GetPageAsync(PaginationFilter pageFilter)
    {
        return await Queryable.ToPagedResponseListAsync(pageFilter);
    }
}