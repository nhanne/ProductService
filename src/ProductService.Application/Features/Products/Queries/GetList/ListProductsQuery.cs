using MediatR;
using ProductService.Common.Dtos.Products;
using ProductService.Common.Filters;
using ProductService.Common.Wrappers;

namespace ProductService.Application.Features.Products.Queries.GetList;

public class ListProductsQuery : IRequest<PagedResponse<List<ProductDto>>>
{
    public PaginationFilter Pagination { get; set; } = new();
    public ListProductsQuery()
    {
    }
    public ListProductsQuery(PaginationFilter pagination)
    {
        Pagination = pagination;
    }
}