namespace Ati.Filmes;

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> Filmes { get; private set; }
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Filmes = new List<Filme>();
    }


    public void AdicionarFilme(Filme filme)
    {
        if (!Filmes.Contains(filme))
        {
            Filmes.Add(filme);
        }
    }


    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }

}