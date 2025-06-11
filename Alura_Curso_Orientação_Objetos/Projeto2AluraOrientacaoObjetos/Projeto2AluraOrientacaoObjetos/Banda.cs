class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    

    private List<Album> albums = new List<Album>();

    public string Nome { get;}

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da Banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Alubun: {album.Nome} ({album.DuracaoTotal}Sg)");
        }



    }
}