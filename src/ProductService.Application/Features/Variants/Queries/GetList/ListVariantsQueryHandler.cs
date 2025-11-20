using AutoMapper;
using MediatR;
using ProductService.Application.Features.Variants.Queries.GetList;
using ProductService.Common.Dtos.Variants;
using ProductService.Common.Wrappers;
using ProductService.Domain.Entities.Variants;

namespace VariantService.Application.Features.Variants.Queries.GetList;

public class ListVariantsQueryHandler : IRequestHandler<ListVariantsQuery, PagedResponse<List<VariantDto>>>
{
    private readonly IMapper _mapper;
    private readonly IVariantReadOnlyRepository _readOnlyrepository;
    public ListVariantsQueryHandler(IMapper mapper,
                                    IVariantReadOnlyRepository readOnlyrepository)
    {
        _mapper = mapper;
        _readOnlyrepository = readOnlyrepository;
    }
    public async Task<PagedResponse<List<VariantDto>>> Handle(ListVariantsQuery query, CancellationToken cancellationToken)
    {
        var pagedData = await _readOnlyrepository.GetPageAsync(query.Pagination);
        var result = _mapper.Map<PagedResponse<List<VariantDto>>>(pagedData);
        return result;
    }
}