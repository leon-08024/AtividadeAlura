namespace Atividade3Orientacao2
{
    internal class ContaBancaria
    {

        protected double saldo {  get; set; }

        public virtual void depositar(double valor)
        {

            saldo += valor;

        }

        public virtual void sacar(double valor)
        {

            saldo -= valor;
        }

        public virtual double VerSaldo() 
        {
            return saldo; 
        }


    }
}
