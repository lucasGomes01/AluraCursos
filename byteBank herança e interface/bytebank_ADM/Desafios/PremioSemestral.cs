using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Desafios
{
    public class PremioSemestral
    {
        public double Salario { get; set; }

        public virtual double RetornarPremioSemestral()
        {
            return this.Salario * 0.2;
        }
    }
}
