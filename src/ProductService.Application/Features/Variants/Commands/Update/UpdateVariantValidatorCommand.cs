using FluentValidation;

namespace ProductService.Application.Features.Variants.Commands.Update;

public class UpdateVariantValidatorCommand : AbstractValidator<UpdateVariantCommand>
{
    public UpdateVariantValidatorCommand()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("Id is required.");
        RuleFor(x => x.Model.ProductId).NotEmpty().NotNull().WithMessage("Product Id is required.");
        RuleFor(x => x.Model.SKU).NotEmpty().NotNull().WithMessage("SKU is required.");
        RuleFor(x => x.Model.UnitPrice).InclusiveBetween(10, 500).WithMessage("Unit Price must be between 10 and 500.");
    }
}