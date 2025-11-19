using ProductService.Domain.Entities.Variants;

namespace ProductService.Infrastructure.Repositories.Variants;

public class VariantRepository : Repository<Variant>, IVariantRepository
{
    public VariantRepository(AppDbContext context) : base(context)
    {
    }
}