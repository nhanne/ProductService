using AutoMapper;
using MediatR;
using ProductService.Common.Dtos.Categories;
using ProductService.Domain.Entities.Products;
using ProductService.Domain.Exceptions.Categories;

namespace ProductService.Application.Features.Categories.Queries.GetById;

public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, CategoryDto>
{
    private readonly IMapper _mapper;
    private readonly IProductReadOnlyRepository _repository;

    public GetCategoryQueryHandler(IMapper mapper, IProductReadOnlyRepository repository)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<CategoryDto> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var category = await _repository.GetByIdAsync(request.Id);
        if (category == null)
        {
            throw new CategoryNotFoundException(request.Id);
        }
        var result = _mapper.Map<CategoryDto>(category);
        return result;
    }
}