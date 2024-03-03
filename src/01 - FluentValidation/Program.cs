using _01___FluentValidation;
using FluentValidation.Results;

var pessoa = new Pessoa { Nome = "João", Idade = 15, Email = "joao@example.com" };

var validator = new PessoaValidator();
ValidationResult results = validator.Validate(pessoa);

if (!results.IsValid)
{
    foreach (var failure in results.Errors)
    {
        Console.WriteLine($"Propriedade: {failure.PropertyName}, Erro: {failure.ErrorMessage}");
    }
}
else
{
    Console.WriteLine("A pessoa é válida.");
}
