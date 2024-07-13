using FluentValidation;

namespace CodeZone.Application.Features.Items.Command.Update
{
    public class UpdateItemCommandValidatorcs : AbstractValidator<UpdateItemCommand>
    {
        public UpdateItemCommandValidatorcs()
        {
            RuleFor(e => e.Name)
             .NotNull().WithMessage("{PropertyName} is required.")
             .NotEmpty().WithMessage("{PropertyName} is required.")
             .MaximumLength(50).WithMessage("{PropertyName} should not exceed 50 Charachers.");
        }
    }
}
