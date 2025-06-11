//Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta,
//como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
    class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string Informacaoes => $"Conta N {this.NumeroConta}, agencia: {this.Agencia}, titular:{this} ";

}
