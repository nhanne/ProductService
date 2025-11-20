using MediatR;
using ProductService.Common.Dtos.Categories;
using ProductService.Common.Filters;
using ProductService.Common.Wrappers;

namespace ProductService.Application.Features.Categories.Queries.GetList;

public class ListCategoriesQuery : IRequest<PagedResponse<List<CategoryDto>>>
{
    public PaginationFilter Pagination { get; set; } = new();
    public ListCategoriesQuery()
    {
    }
    public ListCategoriesQuery(PaginationFilter pagination)
    {
        Pagination = pagination;
    }
}