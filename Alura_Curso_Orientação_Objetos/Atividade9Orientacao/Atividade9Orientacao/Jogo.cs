//Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.

class Jogo
{
  

    public Jogo(string nome, string genero, int anoLancamento)
    {
        Nome = nome;
        Genero = genero;
        AnoLancament = anoLancamento;
    }

    public string Nome { get; set; }
    public string Genero { get; set; }
    public int AnoLancament { get; set; }
}