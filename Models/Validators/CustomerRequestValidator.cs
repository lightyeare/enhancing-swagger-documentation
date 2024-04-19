using FluentValidation;

namespace EnhancingSwagger.Models.Validators;

public class CustomerRequestValidator: AbstractValidator<CustomerRequest>
{
    public CustomerRequestValidator()
    {
        RuleFor(x => x.Status)
            .NotEmpty()
            .WithMessage("You must specify a status.")
            .Must(status => status is "Active" or "Inactive")
            .WithMessage("Invalid Status. Valid values are Active,Inactive.");
    }
}