namespace ProductService.Domain.Abtractions;

public interface IReadOnlyRepository<T> where T : class
{
    Task<T?> GetByIdAsync(Guid id);
    IQueryable<T> GetQueryable();
}