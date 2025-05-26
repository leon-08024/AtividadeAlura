using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

string mendsagemDeBoasVindas = "Boas Vindas ao Screen Sound";

List<string> listaDasBandas = new List<string> { "U2","The Beatles","Calipso","Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" }; 

static void ExibirLogo(string mendsagemDeBoasVindas)
{
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
    ExibirLogo(mendsagemDeBoasVindas);
    Console.WriteLine("\nDigite    1 para registrar uma Banda");
    Console.WriteLine("Digite    2 para mostra todas as Bandas");
    Console.WriteLine("Digite    3 para avaliar uma Banda");
    Console.WriteLine("Digite    4 para mostrar a media de uma banda");
    Console.WriteLine("Digite   -1 para Sair");

    Console.Write("\n Digite sua Opcao: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Voce escolheu a opcao " + opcaoEscolhidaNumerica);
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
        Console.WriteLine("************************************");
        Console.WriteLine("Registro de Banda");
        Console.WriteLine("************************************\n");
        Console.WriteLine("Digite o nome da banda que deseja registra: ");
        string nomeDaBanda = Console.ReadLine()!;
        listaDasBandas.Add(nomeDaBanda);
        Console.WriteLine($"\nA Banda {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        ExbirOpcoesDoMenu();

    }

    void MostrarBandasRegistradas()
    {
        Console.Clear();
        Console.WriteLine("************************************");
        Console.WriteLine("Exibindo Todas as Bandas Registradas");
        Console.WriteLine("************************************\n");
        foreach(var i in listaDasBandas)
        {
            Console.WriteLine($"Banda :{i} ");
        }

        Console.WriteLine("\ndigite qualquer tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear() ;
        ExbirOpcoesDoMenu();
    }

}

ExbirOpcoesDoMenu();

