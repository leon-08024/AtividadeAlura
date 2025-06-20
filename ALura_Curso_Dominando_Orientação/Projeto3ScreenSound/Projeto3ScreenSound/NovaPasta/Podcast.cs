namespace Screensound.Modelos; 

class PodCast
{
    private List<Episodio> episodios = new List<Episodio>();
    public PodCast(string host, string nome)
    {
        Host = host;
        Nome = nome;

    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;


    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        Console.WriteLine($"Episódio adicionado! Total de episódios: {TotalEpisodios}");

    }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"O podcast {Nome} do {Host}");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este Podcast tem {TotalEpisodios} Episodios" +
            $"");



} 
}
