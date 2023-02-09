namespace bytebank_ADM.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string Cpf) : base(Cpf, 3000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
