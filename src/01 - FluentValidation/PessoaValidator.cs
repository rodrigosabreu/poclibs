using _01___FluentValidation;
using FluentValidation;

public class PessoaValidator : AbstractValidator<Pessoa>
{
    public PessoaValidator()
    {
        RuleFor(pessoa => pessoa.Nome)
            .NotEmpty()
            .WithMessage("O nome não pode estar vazio.");

        RuleFor(pessoa => pessoa.Idade)
            .InclusiveBetween(18, 120)
            .WithMessage("A idade deve estar entre 18 e 120 anos.");

        RuleFor(pessoa => pessoa.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("O email não é válido.");

        RuleFor(pessoa => pessoa.Endereco).SetValidator(new EnderecoValidator());

        RuleFor(pessoa => pessoa.Endereco.Cidade)
            .NotNull()
            .NotEmpty()
            .When(pessoa => pessoa.Endereco != null)
            .WithMessage("A cidade deve ser informada.");

    }
}