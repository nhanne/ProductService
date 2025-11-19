using AutoMapper;
using MediatR;
using ProductService.Common.Dtos.Categories;
using ProductService.Common.Wrappers;
using ProductService.Domain.Entities.Categories;

namespace ProductService.Application.Features.Categories.Queries.GetList;

public class ListCategoriesQueryHandler : IRequestHandler<ListCategoriesQuery, PagedResponse<List<CategoryDto>>>
{
    private readonly IMapper _mapper;
    private readonly ICategoryReadOnlyRepository _readOnlyrepository;
    public ListCategoriesQueryHandler(IMapper mapper,
                                      ICategoryReadOnlyRepository readOnlyrepository)
    {
        _mapper = mapper;
        _readOnlyrepository = readOnlyrepository;
    }
    public async Task<PagedResponse<List<CategoryDto>>> Handle(ListCategoriesQuery query, CancellationToken cancellationToken)
    {
        var pagedData = await _readOnlyrepository.GetPageAsync(query.Pagination);
        var result = _mapper.Map<PagedResponse<List<CategoryDto>>>(pagedData);
        return result;
    }
}
