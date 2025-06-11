//Criar um construtor para a classe Titular, que inicialize todas suas propriedades:
//Criar um construtor para a classe Conta, que inicialize todas suas propriedades:
//Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.

Titular titular = new Titular("Corey Taylor","000.000.000-00","rua ai meu");
Conta c = new Conta(titular, 1, 54,100000);

Console.WriteLine(c.Informacoes);