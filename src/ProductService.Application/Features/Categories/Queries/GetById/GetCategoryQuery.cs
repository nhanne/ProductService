using MediatR;
using ProductService.Common.Dtos.Categories;

namespace ProductService.Application.Features.Categories.Queries.GetById;

public record GetCategoryQuery(Guid Id) : IRequest<CategoryDto>;