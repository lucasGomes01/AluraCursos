using byteBank.Titular;

namespace byteBank.Contas
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
                return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
                return false;
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + titular);
            Console.WriteLine("Conta :" + conta);
            Console.WriteLine("Número Agência :" + numero_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}
