using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

//Funcionario pedro = new("123456789", 2000)
//{
//    Nome = "Pedro"
//};

//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new("123456789")
//{
//    Nome = "Roberta Silva"
//};

//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);
//Console.WriteLine(gerenciador.TotalDeBonificacao);
//Console.WriteLine(Funcionario.TotalDeFuncionario);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("pedro salário:" + pedro.Salario);
//Console.WriteLine("roberta salário:" + roberta.Salario);

CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new();

    Designer ulisses = new("643212");
    ulisses.Nome = "ulisses Souza";

    Diretor Paula = new("343214");
    Paula.Nome = "Paula";

    Auxiliar igor = new("34243");
    igor.Nome = "Igor";

    GerenteDeContas Camila = new("23423");
    Camila.Nome = "Camila";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(Paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(Camila);

    Console.WriteLine(gerenciador.TotalDeBonificacao);
}