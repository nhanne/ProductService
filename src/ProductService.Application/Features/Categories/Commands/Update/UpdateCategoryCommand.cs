using MediatR;
using ProductService.Common.Dtos.Categories;

namespace ProductService.Application.Features.Categories.Commands.Update;

public record UpdateCategoryCommand(UpdateCategoryDto Model) : IRequest;