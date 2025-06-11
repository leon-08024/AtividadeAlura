class Musica
{

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {  get; }
    public Banda Artista {  get;  }
    public int Duracao {  get; set; }
    public bool Disponivel {  get; set; }
    public Genero genero { get; set; }

    public string DescricaoResumida => $"A Musica {Nome} pertence ao Artista: {Artista}";
        


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {

            Console.WriteLine("Disponivel no app");
        }
        else
        {
            Console.WriteLine("Nao disponivel no momento");

        }
    }
   
}
    