namespace Atividade3Orientacao2
{
    internal class ContaCorrente : ContaBancaria
    {

        private double Taxa {  get; set; }


        public override void sacar(double valor)
        {
            base.sacar(valor+Taxa);
        }

    }
}
