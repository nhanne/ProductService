using FluentValidation;

namespace ProductService.Application.Features.Categories.Commands.Update;

public class UpdateCategoryValidatorCommand : AbstractValidator<UpdateCategoryCommand>
{
    public UpdateCategoryValidatorCommand()
    {
        RuleFor(x => x.Model.Name).NotEmpty().WithMessage("Name is required.")
                                  .Length(5, 50).WithMessage("Name must be between 5 and 50 characters.");
    }
}