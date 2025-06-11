//Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.


class CatalogosJogos
{

    private List<Jogo> jogos { get; set; }

    public bool CatalogoVazio => jogos.Count == 0;

    public CatalogosJogos()
    {
        jogos = new List<Jogo>();
    }

    public void AdicionarJogo(string nome, string genero, int anoLancamento)
    {
        Jogo novoJogo = new Jogo(nome, genero, anoLancamento);
        jogos.Add(novoJogo);
        Console.WriteLine($"o jogo {nome} foi adicionado");
    }

    public void ExibirCatalogo()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O catalogo esta vazio cheque novo mais tarde ");

        }
        else
        {
            Console.WriteLine("Catalogo de jogos:")
                foreach (var jogo in jogos)
            {
                Console.WriteLine($"Nome: {jogo.Nome} - Genero: {jogo.Genero} - Ano de Lancamento: {jogo.AnoLancament}");
            }
        }

    }
}