namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticavel
    { 

        public GerenteDeContas(string Cpf) : base(Cpf, 4000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
