namespace Atividade5Orientacao2
{
    internal class Notebook : ProdutoEletronico
    {
        public string Processor {  get; set; }

        public override string ExibirSpecs()
        {
            return $"{base.ExibirSpecs()} Processador: {Processor}";
        }
    }
}
