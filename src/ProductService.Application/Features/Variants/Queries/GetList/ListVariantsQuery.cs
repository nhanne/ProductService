using MediatR;
using ProductService.Common.Dtos.Variants;
using ProductService.Common.Filters;
using ProductService.Common.Wrappers;

namespace ProductService.Application.Features.Variants.Queries.GetList;

public class ListVariantsQuery : IRequest<PagedResponse<List<VariantDto>>>
{
    public PaginationFilter Pagination { get; set; } = new();
    public ListVariantsQuery()
    {
    }
    public ListVariantsQuery(PaginationFilter pagination)
    {
        Pagination = pagination;
    }
}