using bytebank_ADM.Parceria;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string login, string senha) 
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Login invalido!");
                return false; 
            }
        }
    }
}
