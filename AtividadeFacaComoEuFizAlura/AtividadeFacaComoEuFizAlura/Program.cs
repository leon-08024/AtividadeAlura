
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

void UsandoFor()
{
    Console.WriteLine("Usando o For: \n");
    for (int i = 0; i < numeros.Count; i++)
{        
        if (numeros[i] % 2 == 0)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.WriteLine("\n");
    }
}

void UsandoForEach()
{
    Console.WriteLine("Usando O For Each: \n");

    foreach (int numero in numeros)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine("\n");
    }
}

UsandoFor();
UsandoForEach();




