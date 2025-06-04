class Musica
{
    public string Nome {  get; set; }
    public string Artista {  get; set; }
    public int Duracao {  get; set; }
    public bool Disponivel {  get; set; }
    public string DescricaoResumida => $"A Musica {Nome} pertence ao Artista: {Artista}";



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
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
    