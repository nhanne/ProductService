using Microsoft.EntityFrameworkCore;
using ProductService.Domain.Exceptions.Variants;

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
}