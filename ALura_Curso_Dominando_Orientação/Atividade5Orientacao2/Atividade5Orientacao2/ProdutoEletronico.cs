namespace Atividade5Orientacao2
{
    internal class ProdutoEletronico
    {
        public string Modelo { get; set; }
        public double Preco { get; set; }

        public virtual string ExibirSpecs()
        {
            return $"Modelo: {Modelo}, Preço: {Preco:C}";
        }
    }
}
