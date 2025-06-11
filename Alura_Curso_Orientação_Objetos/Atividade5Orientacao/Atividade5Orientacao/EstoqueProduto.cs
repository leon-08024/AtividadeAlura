class EstoqueProduto
{
    private List<Produto> Produtos { get; set; } = new List<Produto>();

    public void AdicionaProduto(Produto produto)
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.nome} foi aduicionado");
    }
    public void ExbirProdutos()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Estoque Vazio. Nenhum produto encontrado");

        }
        else
             {
                 Console.WriteLine("Lista de produtos no estoque:");
                    foreach (var produto in Produtos)
                    {
                      Console.WriteLine(produto.Descricao);
                    }
            }
    }
}

