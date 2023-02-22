using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(string Cpf) : base(Cpf, 5000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
