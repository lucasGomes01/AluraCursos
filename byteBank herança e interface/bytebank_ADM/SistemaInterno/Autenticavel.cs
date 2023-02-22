using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public abstract bool Autenticar(string login, string senha);

        public Autenticavel(string Cpf, double salario) : base(Cpf, salario)
        {
        }
    }
}
