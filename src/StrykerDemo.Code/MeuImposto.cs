
using System.Collections.Generic;

namespace StrykerDemo.Code
{
    public class MeuImposto : ITributos
    {
        public MeuImposto()
        {
        }

        public decimal Calcular(IReadOnlyCollection<Produtos> produtos)
        {
            decimal valor = 0;
            foreach (var produto in produtos)
            {
                    valor += produto.Valor;
            }

            if(valor > 100)
                 valor += 10;

            if(produtos.Count > 5)
                valor += 5;

                return valor;
        }
    }
}