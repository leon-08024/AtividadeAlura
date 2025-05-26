//Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas 
//(adição, subtração, divisão e multiplicação), utilizando interpolação de strings



void QuatroOperacoes()
{
    float a = 4;
    float b = 5;

    float soma = a + b;
    float substracao = a - b;
    float divisao = a / b;
    float multiplicacao = b * a;

    Console.WriteLine("Operaçoes\n");
    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}\n")
    Console.WriteLine($"a + b = {soma}");
    Console.WriteLine($"a - b = {substracao}");
    Console.WriteLine($"a * b = {divisao}");
    Console.WriteLine($"a / b = {multiplicacao}");

}

QuatroOperacoes();