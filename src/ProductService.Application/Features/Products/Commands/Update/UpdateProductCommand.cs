using MediatR;
using ProductService.Common.Dtos.Products;

namespace ProductService.Application.Features.Products.Commands.Update;

public record UpdateProductCommand(Guid Id, UpdateProductDto Model) : IRequest;