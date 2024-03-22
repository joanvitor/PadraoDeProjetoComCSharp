using Solucoes.Criacionais.FactoryMethod.Interfaces;

namespace Solucoes.Criacionais.FactoryMethod.Servicos
{
    public class PremiumServico : IServico
    {
        public PremiumServico()
        {
            Console.WriteLine("Produto premium serviço criado!");
        }

        public void ExecutarCobranca()
        {
            // logica premium
        }
    }
}