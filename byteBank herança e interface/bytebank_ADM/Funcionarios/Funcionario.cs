using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionario { get; private set; }

        public Funcionario(string Cpf, double salario) {
            this.Salario = salario;
            this.Cpf = Cpf;
            TotalDeFuncionario++;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }    
}
