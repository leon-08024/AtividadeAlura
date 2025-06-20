class Episodio
{
    private List<string> Convidados = new List<string>();

    public int Duracao { get; }
    public int Ordem { get;  }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao}) - {string.Join(", ", Convidados)}";
    public string Titulo { get; }

    

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }


    public void AdicionarConvidados(string convidado)
    {
        Convidados.Add(convidado);

    }
}

