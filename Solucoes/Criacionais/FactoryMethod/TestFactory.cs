namespace Solucoes.Criacionais.FactoryMethod
{
    public class TestFactory
    {
        public void ExecutarCriacaoProduto()
        {
            var selecionador = new SelecionaServico();

            while (true)
            {
                Console.WriteLine("Selecione o serviço: ");
                Console.WriteLine("0 - Tradicinal");
                Console.WriteLine("1 - Premium");
                Console.WriteLine("2 - Master");
                Console.WriteLine("3 - Cobertura");
                Console.WriteLine("4 - X Serviço");

                Console.WriteLine("Informe o serviço:");
                var servicoSelecionado = Convert.ToInt32(Console.ReadLine());

                var servico = selecionador.FabricarProduto((TipoServico)servicoSelecionado);
            }
        }
    }
}