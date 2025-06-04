using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<int> numeros = new List<int> {5,6,7,8,9,10 }; 
int soma = 0;



foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma}");