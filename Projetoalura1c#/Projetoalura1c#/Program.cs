using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

string mendsagemDeBoasVindas = "Boas Vindas ao Screen Sound";

// List<string> listaDasBandas = new List<string> { "U2","The Beatles","Calipso","Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" }; 
Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Beatles", new List<int>());


static void ExibirLogo(string mendsagemDeBoasVindas)
{
    //Logo e a Mensagem de Boas Vindas
    Console.WriteLine(@"
░██████╗██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mendsagemDeBoasVindas);

}


void ExbirOpcoesDoMenu()
{
    //exibe a logo e da as opcoes de como proseguir
    ExibirLogo(mendsagemDeBoasVindas);
    Console.WriteLine("\nDigite    1 para registrar uma Banda");
    Console.WriteLine("Digite    2 para mostra todas as Bandas");
    Console.WriteLine("Digite    3 para avaliar uma Banda");
    Console.WriteLine("Digite    4 para mostrar a media de uma banda");
    Console.WriteLine("Digite   -1 para Sair");


    //Pede ao usuario para digitar a opcao escolhida e transforma a string de opcao escolhida de string em int
    Console.Write("\n Digite sua Opcao: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        //todos os casos
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Voce escolheu a opcao " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau Tchau :) ");
            break;
        default:
            Console.WriteLine("opcao invalida");
            break;

    }
    void RegistrarBanda()
    {
        
        Console.Clear();
        ExibirTituloDaOpcao("registro das bandas");

        // pede para o usuario digitar uma banda quui queira registrar
        // depois diz se a banda foi registrada com sucesso
        Console.WriteLine("Digite o nome da banda que deseja registra: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"\nA Banda {nomeDaBanda} foi registrada com sucesso");

        //Pedir para o Usuario Precionar tecla para sair
        Console.WriteLine("\ndigite qualquer tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExbirOpcoesDoMenu();
    }

    void MostrarBandasRegistradas()
    {
        //Mostrar Bandas Registradas
        Console.Clear();
        ExibirTituloDaOpcao("Mostrando todas as Bandas Registradas");
        foreach (var i in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda :{i} ");
        }

        //Pedir para o Usuario Precionar tecla para sair
        Console.WriteLine("\ndigite qualquer tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExbirOpcoesDoMenu();
    }

    void AvaliarUmaBanda()
    {
        //digite qual banda avaliar
        //se a banda existir no dicionario >> atribuir nota
        //senao volta para o menu principal
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {

            //Peco a nota e transforma a nota que esta  em strin em int 
            // e depois adiciono ela ao dicionario
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                int nota = int.Parse(Console.ReadLine());
                bandasRegistradas[nomeDaBanda].Add(nota);
                Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");


            //Pedir para o Usuario Precionar tecla para sair
            Console.WriteLine("\ndigite qualquer tecla para voltar para o menu principal");
            Console.ReadKey();
            Console.Clear();
            ExbirOpcoesDoMenu();

        }
        else
        {
            // falar para ele que a banda digitada nao foi encontrada
            //Pedir para o Usuario Precionar tecla para sair
            Console.WriteLine($"\nA banda {nomeDaBanda} nao foi encontrada");
            Console.WriteLine("\ndigite qualquer tecla para voltar para o menu principal");
            Console.ReadKey();
            Console.Clear();
            ExbirOpcoesDoMenu();

        }

    }

    void ExibirTituloDaOpcao(string titulo)
    {
        //verifica a quantidade de caracteres no titulo e os tranforma em um int
        // e depois os astericos sao adicionados pela esquerda dependendo da quantidade de letras do titulo
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

}
ExbirOpcoesDoMenu();

