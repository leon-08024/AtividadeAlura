Episodio ep1 = new(100, 1, "Podcast ai meu");
ep1.AdicionarConvidados("jorginho");
ep1.AdicionarConvidados("Kleberson");

Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(102, 2, "Podcast ai meu2");
ep2.AdicionarConvidados("jorginho");
ep2.AdicionarConvidados("Kleberson");
ep2.AdicionarConvidados("Marcio");

Console.WriteLine(ep2.Resumo);


PodCast podCast = new("Arquelau", "PodAlgumaCoisa");
podCast.AdicionarEpisodio(ep1);
podCast.AdicionarEpisodio(ep2);
podCast.ExibirDetalhes();