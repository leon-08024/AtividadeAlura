namespace Atividade5Orientacao2
{
    internal class SmartPhone : ProdutoEletronico
    {
        public string SistemaOperacional { get; set; }

        public override string ExibirSpecs()
        {
            return $"{base.ExibirSpecs()}, Sistema: {SistemaOperacional}";
        }
    }
}
