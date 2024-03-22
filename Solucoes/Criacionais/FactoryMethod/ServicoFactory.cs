using Solucoes.Criacionais.FactoryMethod.Interfaces;

namespace Solucoes.Criacionais.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico FabricarProduto(TipoServico tipo);
    }
}