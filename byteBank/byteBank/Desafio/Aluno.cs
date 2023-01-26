using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Desafio
{
    class Aluno
    {
        private int matricula;
        public int Matricula
        {
            get { return this.matricula; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Valor da matrícula não pode ser menor que zero.");
                else
                    this.matricula = value;
            }
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
    }
}
