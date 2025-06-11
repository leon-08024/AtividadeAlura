//Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
Titular t = new();
Conta c = new();

t.Nome = "Corey Taylor";
t.Cpf = "742.666.617-27";
t.Endereco = "Rua da Dualidade - Los Angeles";

c.Titular = t;
c.Agencia = 1;
c.NumeroConta = 6996;
c.Saldo = 74261700002.7;
c.Limite = 100000.0;

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {c.Titular.Nome}");
Console.WriteLine($"CPF: {c.Titular.Cpf}");
Console.WriteLine($"Endereco: {c.Titular.Endereco}");