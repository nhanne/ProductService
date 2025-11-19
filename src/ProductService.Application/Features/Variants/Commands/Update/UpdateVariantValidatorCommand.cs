using FluentValidation;

namespace ProductService.Application.Features.Variants.Commands.Update;

public class UpdateVariantValidatorCommand : AbstractValidator<UpdateVariantCommand>
{
    public UpdateVariantValidatorCommand()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("Id is required.");
    }
}