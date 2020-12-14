using System.Collections.Generic;
namespace StrykerDemo.Code
{
    public interface ITributos
    {
        decimal Calcular(IReadOnlyCollection<Produtos> produtos);
    }
}