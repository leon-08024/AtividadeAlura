namespace Ati.Filmes;


class Filme
{
    public string Titulo { get; set; }
    public TimeSpan Duracao { get; set; }
    public List<Artista> Elenco { get; private set; }




    public Filme(string titulo, TimeSpan duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
        Elenco = new List<Artista>();
    }
    public void AdicionarArtista(Artista artista)
    {
        if (!Elenco.Contains(artista))
        {
            Elenco.Add(artista);
            artista.AdicionarFilme(this);
        }
    }
    public override string ToString()
    {
        return $"Título: {Titulo}, Duração: {Duracao}";
    }
}

