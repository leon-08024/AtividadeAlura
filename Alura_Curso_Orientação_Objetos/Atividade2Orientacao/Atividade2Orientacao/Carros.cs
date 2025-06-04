//Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
//Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.




class Carro
{
    public string Fabricante { get; set; };
    public string Modelo { get; set; };
    public int Ano { 
               
        get => Ano;

        set
        {
            if (value<1960 || value> 2025)
            {
                Console.WriteLine("Valor Invalido");
            }
            else
            {
                Ano = value;    
            }
        }
       
    
    };
    public int QuantidaDePortas { get; set; };
    public int Velocidade = 0;
    public string DescricaoDetalhada => $"Modelo do carro: {this.fabricante} {this.modelo},{this.ano}"

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: {this.fabricante} {this.modelo}, {this.quantidadePortas} portas, {this.ano}");
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando");
        if (velocidade < 100)
        {
            velocidade = velocidade + 5;
        }
    }

    public void Frear()
    {
        Console.WriteLine("Freando");
        if (velocidade > 0)
        {
            velocidade = velocidade - 5;
        }
    }

    public void Buzinar()
    {
        Console.WriteLine("PAROOOO PAROOOOOO");
    }
}