//Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

void NotasSistema()
{

    // Criar um dicionário para representar um aluno
    Dictionary<string, object> aluno = new Dictionary<string, object>
        {
            { "Nome", "João" },
            { "Notas", new List<double> { 7.5, 8.0, 9.0, 6.5 } }
        };
    // Obter a lista de notas do dicionário
    List<double> notas = (List<double>)aluno["Notas"];
    // Calcular a média das notas
    double media = notas.Average();
    // Mostrar a média na tela  
    Console.WriteLine($"A média das notas de {aluno["Nome"]} é: {media:F2}");

}
NotasSistema();