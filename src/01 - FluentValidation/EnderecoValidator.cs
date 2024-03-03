using _01___FluentValidation;
using FluentValidation;

public class EnderecoValidator : AbstractValidator<Endereco>
{
    public EnderecoValidator()
    {
        RuleFor(address => address.Logradouro)
            .NotEmpty()
            .NotNull()
            .WithMessage("O logradouro não pode estar vazio.");
    }
}