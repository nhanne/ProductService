using MediatR;
using ProductService.Common.Dtos.Variants;

namespace ProductService.Application.Features.Variants.Commands.Create;

public record CreateVariantCommand(CreateVariantDto Model) : IRequest<Guid>;