//Crie um programa que implemente um quiz simples de perguntas e respostas. 
//Utilize um dicionário para armazenar as perguntas e as respostas corretas.



// Dicionário com perguntas (chaves) e respostas corretas (valores)
Dictionary<string, string> quiz = new Dictionary<string, string>
        {
            { "Qual a capital do Brasil?", "Brasilia" },
            { "Quantos estados tem o Brasil?", "26" },
            { "Qual a cor do céu em um dia claro?", "Azul" },
            { "Quem descobriu o Brasil?", "Pedro Álvares Cabral" },
            { "Qual o maior planeta do sistema solar?", "Jupiter" }
        };
void QuizConhecimento()
{
    int pontos = 0;
    Console.WriteLine("Quiz simples - Responda as perguntas abaixo:\n");
    foreach (var pergunta in quiz)
    {
        Console.WriteLine(pergunta.Key);
        Console.Write("Sua resposta: ");
        string respostaUsuario = Console.ReadLine()?.Trim() ?? "";
        // Comparar resposta ignorando maiúsculas/minúsculas
        if (string.Equals(respostaUsuario, pergunta.Value, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Resposta correta\n");
            pontos++;
        }
        else
        {
            Console.WriteLine($"Resposta incorreta. A resposta correta é: {pergunta.Value}\n");
        }
    }
    Console.WriteLine($"Você respondeu corretamente {pontos} de {quiz.Count} perguntas.");
}

QuizConhecimento();