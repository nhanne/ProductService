using FluentValidation;
using ProductService.Application.Features.Products.Commands.Delete;

namespace ProductService.Application.Features.Variants.Commands.Delete;

public class DeleteVariantValidatorCommand : AbstractValidator<DeleteVariantCommand>
{
    public DeleteVariantValidatorCommand()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("Id is required.");
    }
}