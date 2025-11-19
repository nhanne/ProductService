using ProductService.Domain.Abtractions;

namespace ProductService.Domain.Entities.Variants;

public interface IVariantRepository : IRepository<Variant>;

public interface IVariantReadOnlyRepository : IReadOnlyRepository<Variant>
{
    Task<Variant?> FindBySKUAsync(string sku);
}