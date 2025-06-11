//Criar um construtor para a classe Titular, que inicialize todas suas propriedades:
//Criar um construtor para a classe Conta, que inicialize todas suas propriedades:
//Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.

class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }

    public string Nome { get;}
    public string Cpf { get;}
    public string Endereco { get;}
}

