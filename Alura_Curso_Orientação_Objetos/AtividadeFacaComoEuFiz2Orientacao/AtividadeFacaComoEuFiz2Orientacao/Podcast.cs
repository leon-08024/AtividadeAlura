//Chegou o momento de você usar a criatividade e praticar todos os conhecimentos aprendidos criando mais classes e evoluindo ainda mais a aplicação que estamos desenvolvendo.
//Crie mais algumas classes e pense no relacionamento com outras classes, atributos, propriedades, métodos, encapsulamento e construtores.
//Para ajudar nesse desafio, vou deixar algumas sugestões de classes que você pode implementar criando suas próprias regras de negócio:
//Classe Podcast: Representa um episódio de um podcast, contendo informações como título, descrição, duração, etc.
class Podcast
{
    public Podcast(string titulo, string descricao, int duracao, string criador)
    {
        Titulo = titulo;
        Descricao = descricao;
        Duracao = duracao;
        Criador = criador;
    }

    public string Titulo {  get; }
    public string Descricao { get; }
    public int Duracao { get; }
    public string Criador { get; }
}