using MediatR;
using ProductService.Common.Dtos.Variants;

namespace ProductService.Application.Features.Variants.Commands.Update;

public record UpdateVariantCommand(Guid Id, UpdateVariantDto Model) : IRequest;