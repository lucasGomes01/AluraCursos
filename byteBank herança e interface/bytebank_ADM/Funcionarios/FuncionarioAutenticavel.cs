using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string Cpf, double salario) : base(Cpf, salario)
        {
        }

        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
