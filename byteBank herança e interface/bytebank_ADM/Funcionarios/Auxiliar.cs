namespace bytebank_ADM.Funcionarios
{
    internal class Auxiliar: Funcionario
    {
        public Auxiliar(string Cpf) : base(Cpf, 2000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
