//Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos 
//e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

Dictionary<string, int> estoque = new Dictionary<string, int>
{
    //estoque que tem a string e int
    {"arroz", 50 },
    {"feijao", 30 },
    {"macarrao",20 },
    {"acucar", 60 },
    {"Oleo", 15 },

};

void ChecarEstoque()
{
    Console.WriteLine("Consulta de estoque da loja");
    Console.Write("\nInforme o nome do produto: ");
    string produto = Console.ReadLine();
    // Verifica se o produto existe no estoque
    if (estoque.ContainsKey(produto))
    {
        int quantidade = estoque[produto];
        Console.WriteLine($"O produto '{produto}' tem {quantidade} unidades em estoque.");
    }
    else
    {
        Console.WriteLine($"Produto '{produto}' não encontrado no estoque.");
    }
}



