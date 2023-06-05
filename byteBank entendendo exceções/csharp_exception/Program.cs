using ByteBank;
using csharp_exception;
using csharp_exception.Contas;


LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch
{
    Console.WriteLine("Leitura de arquivo interrompida");
}
finally
{
    leitor.Fechar();
}

//try
//{
//    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
//    //conta1.Sacar(110);
//    //Console.WriteLine(conta1.GetSaldo());
//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
//    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Message);    
//}
//catch (SaldoInsuficienteException ex) 
//{
//    Console.WriteLine("Operação negada! Saldo Insuficiente!");
//    Console.WriteLine(ex.Message);
//}