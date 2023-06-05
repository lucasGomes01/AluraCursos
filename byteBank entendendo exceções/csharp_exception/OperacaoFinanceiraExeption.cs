namespace csharp_exception
{
    public class OperacaoFinanceiraExeption : Exception
    {
        public OperacaoFinanceiraExeption(string mensagem) : base(mensagem)
        {
        }

        public OperacaoFinanceiraExeption(string mensagem, Exception execao): base(mensagem, execao)
        {

        } 
    }
}
