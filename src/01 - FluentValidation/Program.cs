using _01___FluentValidation;
using FluentValidation;
using FluentValidation.Results;

var pessoa = new Pessoa { 
    Nome = "rodrigo",
    Idade = 15, 
    Email = "joao@example.com",
    Endereco = new Endereco
    {
        Logradouro = "rua teste",
        Cidade = "Suzano"
    }
};

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
