//Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
//Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
//Desenvolver um método da classe Conta que exibe suas informações.


//Atividade 3
//Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.

class Dados
{
    public int numeroIndicador { get; set; }
    public string titular {  get; set; }
    public int saldo { get; set; }
    public int senha { get; set; } 

    public void ExibirDadosbancarios()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Numero Indicador: {numeroIndicador}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"senha: {senha}");
    }

}