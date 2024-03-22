using Solucoes.Criacionais.FactoryMethod.Interfaces;

namespace Solucoes.Criacionais.FactoryMethod.Servicos
{
    public class MasterServico : IServico
    {
        public MasterServico()
        {
            Console.WriteLine("Produto master serviço criado!");
        }

        public void ExecutarCobranca()
        {
            // logica master
        }
    }
}