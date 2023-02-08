namespace bytebank_ADM.Desafios
{
    public class Diretoria: PremioSemestral
    {
        public override double RetornarPremioSemestral()
        {
            return this.Salario + base.RetornarPremioSemestral();
        }
    }
}
