using FluentValidation;

namespace ProductService.Application.Features.Categories.Commands.Create;

public class CreateCategoryValidatorCommand : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryValidatorCommand()
    {
        RuleFor(x => x.Model.Name).NotEmpty().WithMessage("Name is required.")
                                  .Length(2, 50).WithMessage("Name must be between 2 and 50 characters.");
        RuleFor(x => x.Model.Code).NotEmpty().WithMessage("Code is required.");
    }
}