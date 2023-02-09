﻿namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
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
    }
}
