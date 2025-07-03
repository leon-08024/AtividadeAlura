using Screensound.Modelos;

namespace Screensound.Menus;

internal class MenuAvaLiarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("       Avaliar Album       ");
        Console.Write("       Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("       Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"       Qual a nota que o album {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\n       A nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\n       O Album {tituloAlbum} não foi encontrada!");
                Console.WriteLine("       Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
                     

        }
        else
        {


            Console.WriteLine($"\n       A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("       Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}

