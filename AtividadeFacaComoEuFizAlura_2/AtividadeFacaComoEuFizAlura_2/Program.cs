//Para manipular elementos na lista em C#, é necessário acessar os elementos usando índices ou chaves, por exemplo.
//É possível adicionar elementos usando o método Add(), remover elementos usando o método Remove() 
//ou alterar elementos diretamente através do seu índice ou chave. Confira abaixo:
//Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores são quantas vezes esse carro foi vendido por ano,
//calcule a média de uma chave específica.

using System.Security.AccessControl;

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> 
{
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

void MediaCarrosVendidos()
{
    Console.Write("Digite o nome do carro que queira ver: ");
    string nomeDoCarro = Console.ReadLine()?.Trim() ?? "";

    if (vendasCarros.ContainsKey(nomeDoCarro))
    {
        List<int> vendas = vendasCarros[nomeDoCarro];

        double mediaVendas = vendas.Average();

        Console.WriteLine($"a media de vendas do {nomeDoCarro} foi de {mediaVendas:F2}");
    }
    else
    {
        Console.WriteLine("carro nao achado");
    }
    
}

MediaCarrosVendidos();  