using MediatR;
using ProductService.Domain.Entities.Variants;
using ProductService.Domain.Exceptions.Variants;

namespace ProductService.Application.Features.Variants.Commands.Delete;

public class DeleteVariantCommandHandler : IRequestHandler<DeleteVariantCommand>
{
    private readonly IVariantRepository _repository;
    public DeleteVariantCommandHandler(IVariantRepository repository)
    {
        _repository = repository;
    }
    public async Task Handle(DeleteVariantCommand command, CancellationToken cancellationToken)
    {
        var product = _repository.GetQueryable().FirstOrDefault(x => x.Id == command.Id);
        if (product == null)
        {
            throw new VariantNotFoundException(command.Id);
        }
        await _repository.Remove(product);
    }
}
