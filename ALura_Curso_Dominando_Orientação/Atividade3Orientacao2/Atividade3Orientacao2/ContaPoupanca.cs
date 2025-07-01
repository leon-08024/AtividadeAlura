namespace Atividade3Orientacao2
{
    internal class ContaPoupanca : ContaBancaria
    {
        private double TaxaRendimento { get; set; }


        public override double VerSaldo()
        {
            return base.VerSaldo() * (1+ TaxaRendimento);
        }
    }
}
