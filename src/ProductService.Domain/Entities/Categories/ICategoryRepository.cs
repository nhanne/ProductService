using ProductService.Common.Filters;
using ProductService.Common.Wrappers;
using ProductService.Domain.Abtractions;

namespace ProductService.Domain.Entities.Categories;

public interface ICategoryRepository : IRepository<Category>;

public interface ICategoryReadOnlyRepository : IReadOnlyRepository<Category>
{
    Task<Category?> FindByCodeAsync(string code);
    Task<Category?> FindByNameAsync(string name);
    Task<PagedResponse<List<Category>>> GetPageAsync(PaginationFilter pageFilter);
}