using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new()
{
    Nome = "Pedro",
    Cpf = "123456789",
    Salario = 2000
};

Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new()
{
    Nome = "Roberta Silva",
    Cpf = "123456789",
    Salario = 5000
};

Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);
Console.WriteLine(gerenciador.TotalDeBonificacao);