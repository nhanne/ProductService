using FluentValidation;

namespace ProductService.Application.Features.Products.Commands.Update;

public class UpdateProductValidatorCommand : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductValidatorCommand()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("Id is required.");
        RuleFor(x => x.Model.Name).NotEmpty();
        RuleFor(x => x.Model.Code).NotEmpty()
                                   .Length(6).WithMessage("Code must be 6 characters.");

        RuleFor(x => x.Model.CostPrice).InclusiveBetween(10, 500).WithMessage("Cost price must be between 10 and 500.");
    }
}