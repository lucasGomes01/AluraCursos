using byteBank;

#region Pratica dos desafios
Produto produto = new();
produto.Valor = 1000;
produto.Nome = "maça";
produto.Fabricante = "";
produto.Quantidade = 1000;
produto.CodigoBarras = 145781324;

//Console.WriteLine("Produto criado do exercício é = " + produto.Nome);
#endregion

#region Codigos que seriam apagados
//contaDoAndre.Depositar(123);
//Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);

//if (contaDoAndre.Sacar(300))
//    Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);
//else
//    Console.WriteLine("Saldo insuficiente para saque");
#endregion

ContaCorrente contaDoAndre = new ContaCorrente
{
    titular = "André Silva",
    numero_agencia = 15,
    conta = "1010-x",
    saldo = 200
};

Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);

ContaCorrente contaDaMaria = new()
{
    titular = "Maria Souza",
    numero_agencia = 17,
    conta = "1010-5",
    saldo = 350
};

Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);
Console.WriteLine("---------------------------------------");

contaDoAndre.Transferir(50, contaDaMaria);

Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);
