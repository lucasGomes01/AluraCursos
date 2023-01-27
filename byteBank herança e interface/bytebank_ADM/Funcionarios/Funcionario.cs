using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        //private int tipo;

        //public Funcionario(int tipo) => this.tipo = tipo;

        public double GetBonificacao()
        {
            //if (tipo == 1)
            //    return this.Salario;

            return this.Salario * 0.10;
        }
    }
}
