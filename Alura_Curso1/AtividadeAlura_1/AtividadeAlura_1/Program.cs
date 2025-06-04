
//Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
//Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.



List<string> bandas = new List<string> {"Slipknot","System of a Down","Deftones","LinkinPark"};


void ListaBanda()
{
    Console.WriteLine("Banda Favoritas:\n");
    foreach (var band in bandas)
    {
        Console.WriteLine("Banda :  " + band);
    }
}

ListaBanda();

