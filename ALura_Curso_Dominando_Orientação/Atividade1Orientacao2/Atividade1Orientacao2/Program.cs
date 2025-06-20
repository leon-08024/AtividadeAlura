using Ati.Filmes;


Artista artista1 = new Artista("Jim Carrey", 63);
Artista artista2 = new Artista("Joseph Gordon-Levittt", 44);
Artista artista3 = new Artista("Zooey Deschanel", 45);
Artista artista4 = new Artista("Jack Black", 55);
Artista artista5 = new Artista("Eddie Redmayne", 43);
Artista artista6 = new Artista("Martin Freeman", 53);



Filme filme1 = new Filme("The Truman Show", new TimeSpan(2, 14, 0));
Filme filme2 = new Filme("500 days of Summer", new TimeSpan(2, 28, 0));
Filme filme3 = new Filme("The Minecraft Movie", new TimeSpan(2, 22, 0));
Filme filme4 = new Filme("Fantastic Beasts", new TimeSpan(1, 49, 0));
Filme filme5 = new Filme("The Hitchhiker’s Guide to The Galaxy", new TimeSpan(1,55,0));

filme1.AdicionarArtista(artista1);
filme2.AdicionarArtista(artista2);
filme2.AdicionarArtista(artista3);
filme3.AdicionarArtista(artista4);
filme4.AdicionarArtista(artista5);
filme5.AdicionarArtista(artista6);
filme5.AdicionarArtista(artista2);



List<Filme> filmesFavoritos = new List<Filme>
        {
            filme1,
            filme2,
            filme3,
            filme4,
            filme5
        };


foreach (var filme in filmesFavoritos)
{
    Console.WriteLine(filme);
    Console.WriteLine("Elenco:");
    foreach (var artista in filme.Elenco)
    {
        Console.WriteLine($" - {artista}");
    }
    Console.WriteLine();
}


