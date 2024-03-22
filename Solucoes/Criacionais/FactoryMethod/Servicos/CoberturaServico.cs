using Solucoes.Criacionais.FactoryMethod.Interfaces;

namespace Solucoes.Criacionais.FactoryMethod.Servicos
{
    public class CoberturaServico : IServico
    {
        public CoberturaServico()
        {
            Console.WriteLine("Produto cobertura serviço criado!");
        }

        public void ExecutarCobranca()
        {
            // lógica cobertura
        }
    }
}