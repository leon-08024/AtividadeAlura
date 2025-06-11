class Produto
{
    private double preco;
    private int estoque;
    public string nome {  get; set; }
    public string marca { get; set; }
    public double Preco
    {
        get => preco; 
        set
        {
            if (value>0)
                preco = value;
            else 
                preco = 10;
        }
    }
    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
                estoque = value;
            else
                estoque = 10;
        }
    }

    public string Descricao => $"{this.nome},{this.marca},{this.preco} - Quantidade: {this.Estoque";




}