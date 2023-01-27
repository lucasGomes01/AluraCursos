using byteBank;
using byteBank.Contas;
using byteBank.Titular;

#region Pratica dos desafios
Produto produto = new();
produto.Valor = 1000;
produto.Nome = "maça";
produto.Fabricante = "";
produto.Quantidade = 1000;
produto.CodigoBarras = 145781324;

//Console.WriteLine("Produto criado do exercício é = " + produto.Nome);

//ContaCorrente contaDoAndre = new ContaCorrente
//{
//    titular = "André Silva",
//    numero_agencia = 15,
//    conta = "1010-x",
//    saldo = 200
//};

//ContaCorrente contaDoAndre2 = new ContaCorrente
//{
//    titular = "André Silva",
//    numero_agencia = 15,
//    conta = "1010-x",
//    saldo = 200
//};

//contaDoAndre2.ExibirDadosDaConta();
//Console.WriteLine(contaDoAndre == contaDoAndre2);
#endregion

#region Codigos que seriam apagados
//contaDoAndre.Depositar(123);
//Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);

//if (contaDoAndre.Sacar(300))
//    Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);
//else
//    Console.WriteLine("Saldo insuficiente para saque");
#endregion

//Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new()
//{
//    titular = "Maria Souza",
//    numero_agencia = 17,
//    conta = "1010-5",
//    saldo = 350
//};

//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);
//Console.WriteLine("---------------------------------------");

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//Console.WriteLine("---------------------------------------");
//ContaCorrente contaDoPedro = new();
//contaDoPedro.titular = "Conta do Pedro";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

//Cliente cliente = new()
//{
//    nome = "André Silva",
//    cpf = "1234566789",
//    profissao = "Analista"
//};

//ContaCorrente conta = new()
//{
//    titular = cliente,
//    conta = "1010-x",
//    numero_agencia = 1,
//    saldo = 100
//};

//Console.WriteLine(conta.titular.nome);

//ContaCorrente conta2 = new();
//conta2.titular = new Cliente();

//conta2.titular.nome = "lucas";
//conta2.titular.cpf = "12345678";
//conta2.titular.profissao = "DEV";
//conta2.conta = "1011-x";
//conta2.numero_agencia = 11;
//conta2.saldo = 1002;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-h";
//conta3.SetSaldo(-10);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-x");
//conta4.Titular = new();
//conta4.Titular.Nome = "Lucas";

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Titular.Nome);

ContaCorrente conta5 = new ContaCorrente(183, "1034-x");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta6 = new ContaCorrente(184, "2034-x");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta7 = new ContaCorrente(184, "2034-x");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);