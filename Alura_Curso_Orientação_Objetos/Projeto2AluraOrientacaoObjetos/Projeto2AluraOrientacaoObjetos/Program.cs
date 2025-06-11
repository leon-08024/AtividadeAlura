
Banda strokes = new Banda("The Strokes");

Album albumDoTheStrokes = new Album("Comedown Machine");

Musica musica1 = new Musica(strokes, "Partners in Crime")
{
    Duracao = 141,
    Disponivel = true,
};



Musica musica2 = new Musica(strokes, "Call it Fate, Call it Karma")
{
    Duracao = 144,
    Disponivel = true,
};

albumDoTheStrokes.AdicionarMusica(musica1);
albumDoTheStrokes.AdicionarMusica(musica2);
strokes.AdicionarAlbum(albumDoTheStrokes);
strokes.ExibirDiscografia();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();