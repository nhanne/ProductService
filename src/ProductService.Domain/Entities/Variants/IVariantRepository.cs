using ProductService.Common.Filters;
using ProductService.Common.Wrappers;
using ProductService.Domain.Abtractions;

namespace ProductService.Domain.Entities.Variants;

public interface IVariantRepository : IRepository<Variant>;

public interface IVariantReadOnlyRepository : IReadOnlyRepository<Variant>
{
    Task<Variant?> FindBySKUAsync(string sku);
    Task<PagedResponse<List<Variant>>> GetPageAsync(PaginationFilter pageFilter);
    Task<PagedResponse<List<Variant>>> GetPageByProductIdAsync(Guid productId, PaginationFilter pageFilter);
}