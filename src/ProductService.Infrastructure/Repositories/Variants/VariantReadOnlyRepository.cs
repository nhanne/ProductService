using Microsoft.EntityFrameworkCore;
using ProductService.Common.Filters;
using ProductService.Common.Wrappers;
using ProductService.Domain.Entities.Products;
using ProductService.Domain.Entities.Variants;
using ProductService.Infrastructure.Helpers;

namespace ProductService.Infrastructure.Repositories.Variants;

public class VariantReadOnlyRepository : ReadOnlyRepository<Variant>, IVariantReadOnlyRepository
{
    public VariantReadOnlyRepository(AppReadOnlyDbContext context) : base(context)
    {

    }
    public async Task<Variant?> FindBySKUAsync(string sku)
    {
        return await Queryable.FirstOrDefaultAsync(x => x.SKU == sku);
    }

    public async Task<PagedResponse<List<Variant>>> GetPageAsync(PaginationFilter pageFilter)
    {
        return await Queryable.ToPagedResponseListAsync(pageFilter);
    }

    public async Task<PagedResponse<List<Variant>>> GetPageByProductIdAsync(Guid productId, PaginationFilter pageFilter)
    {
        return await Queryable.Where(x => x.ProductId == productId).ToPagedResponseListAsync(pageFilter);
    }
}