namespace csharp_exception
{
    public class SaldoInsuficienteException: OperacaoFinanceiraExeption
    {
        public SaldoInsuficienteException(string message) : base(message) 
        {
            
        }
    }
}
