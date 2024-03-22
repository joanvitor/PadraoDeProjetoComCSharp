using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solucoes.Criacionais.FactoryMethod.Interfaces;

namespace Solucoes.Criacionais.FactoryMethod.Servicos
{
    public class XServico : IServico
    {
        public XServico()
        {
            Console.WriteLine("Vinicius");
        }
        public void ExecutarCobranca()
        {
            throw new NotImplementedException();
        }
    }
}
