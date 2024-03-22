using Solucoes.Criacionais.FactoryMethod.Interfaces;

namespace Solucoes.Criacionais.FactoryMethod.Servicos
{
    public class TradicionalServico : IServico
    {
        public TradicionalServico()
        {
            Console.WriteLine("Produto tradicional serviço criado!");
        }

        public void ExecutarCobranca()
        {
            // lógica tradicional
        }
    }
}