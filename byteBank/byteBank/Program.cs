using byteBank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 15.123000;

Produto produto = new();
produto.Valor = 1000;
produto.Nome = "maça";
produto.Fabricante = "";
produto.Quantidade = 1000;
produto.CodigoBarras = 145781324;

Console.WriteLine("Saldo da conta do Andre = " + contaDoAndre.saldo);
Console.WriteLine("Produto criado do exercício é = " + produto.Nome);