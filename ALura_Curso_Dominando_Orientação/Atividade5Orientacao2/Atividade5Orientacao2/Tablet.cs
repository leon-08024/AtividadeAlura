namespace Atividade5Orientacao2
{
    internal class Tablet : ProdutoEletronico
    {
        public string TipoTela { get; set; }

        public override string ExibirSpecs()
        {
            return $"{base.ExibirSpecs()}, Tipo de tela: {TipoTela}";
        }

    }
}
