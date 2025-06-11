//Criar um construtor para a classe Titular, que inicialize todas suas propriedades:
//Criar um construtor para a classe Conta, que inicialize todas suas propriedades:
//Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.

class Conta
{
    public Conta(Titular titular, int agencia, int numeroDaConta, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Limite = limite;
    }

    public Titular Titular { get;  }
    public int Agencia { get; }
    public int NumeroDaConta { get;  }
    public double Saldo { get; }
    public double Limite { get; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}