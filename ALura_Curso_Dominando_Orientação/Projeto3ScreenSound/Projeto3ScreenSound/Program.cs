using Screensound.Menus;
using Screensound.Modelos;


Banda strokes = new Banda("The Strokes");
strokes.AdicionarNota(new Avaliacao(10));
strokes.AdicionarNota(new Avaliacao(8));
strokes.AdicionarNota(new Avaliacao(6));
Banda benches = new("The Benches");


Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(strokes.Nome, strokes);
bandasRegistradas.Add(benches.Nome, benches);

Dictionary<int,Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarUmaBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSaiu());



void ExibirLogo()
        {
                    Console.WriteLine(@"

        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
        ");
                    Console.WriteLine("       Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
{

    ExibirLogo();
    Console.WriteLine("\n       Digite 1 para registrar uma banda");
    Console.WriteLine("       Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("       Digite 3 para mostrar todas as bandas");
    Console.WriteLine("       Digite 4 para avaliar uma banda");
    Console.WriteLine("       Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("       Digite -1 para sair");

    Console.Write("\n       Digite a sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {

        Menu menuASerExirbido = opcoes[opcaoEscolhidaNumerica];
        menuASerExirbido.Executar(bandasRegistradas);
        if(opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {

    }

}

        ExibirOpcoesDoMenu();