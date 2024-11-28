using FluentValidation;
using ConsumerTrampos.Application.Consumers.Commands;

namespace ConsumerTrampos.Application.Consumers.Validators;

public class CreateConsumerCommandValidator : AbstractValidator<CreateConsumerCommand>
{
    public CreateConsumerCommandValidator()
    {
        RuleFor(v => v.CompanyName)
            .MaximumLength(255)
            .NotEmpty();

        RuleFor(v => v.CompanySize)
            .IsInEnum();
    }
}