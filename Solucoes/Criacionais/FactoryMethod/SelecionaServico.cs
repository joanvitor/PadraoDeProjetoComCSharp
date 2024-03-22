using Solucoes.Criacionais.FactoryMethod.Interfaces;
using Solucoes.Criacionais.FactoryMethod.Servicos;

namespace Solucoes.Criacionais.FactoryMethod
{
    public class SelecionaServico : ServicoFactory
    {
        public override IServico FabricarProduto(TipoServico tipo)
        {
            switch (tipo)
            {
                case TipoServico.Tradicional:
                    return new TradicionalServico();
                case TipoServico.Premium:
                    return new PremiumServico();
                case TipoServico.Master:
                    return new MasterServico();
                case TipoServico.Cobertura:
                    return new CoberturaServico();
                case TipoServico.XServico:
                    return new XServico();
                default:
                    return null;
            }
        }
    }
}