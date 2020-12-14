using System.Collections.Generic;
using StrykerDemo.Code;
using FluentAssertions;
using Xunit;

namespace StrykerDemo.Teste
{
   public class MeuImpostoTeste
    {
        [Fact]
        public void Deve_incidir_dez_reais_de_imposto_com_valores_acima_de_cem_reais()
        {
            var imposto = new MeuImposto();
            var produtos = new List<Produtos>();

            produtos.Add(new Produtos(Codigo:1, Nome:"Produto 1", Valor: 200m));
            produtos.Add(new Produtos(Codigo:2, Nome:"Produto 2", Valor: 200m));
            produtos.Add(new Produtos(Codigo:3, Nome:"Produto 3", Valor: 200m));
            produtos.Add(new Produtos(Codigo:4, Nome:"Produto 4", Valor: 200m));
            produtos.Add(new Produtos(Codigo:5, Nome:"Produto 5", Valor: 200m));
            
            var valorEsperado = 1010m;
            var valor = imposto.Calcular(produtos);

            valor.Should().Be(valorEsperado);

        }

        [Fact]
        public void Deve_incidir_cinco_reais_de_imposto_acima_de_cinco_produtos()
        {
            var imposto = new MeuImposto();
            var produtos = new List<Produtos>();

            produtos.Add(new Produtos(Codigo:0, Nome:"Produto 1", Valor: 1m));
            produtos.Add(new Produtos(Codigo:1, Nome:"Produto 2", Valor: 2m));
            produtos.Add(new Produtos(Codigo:2, Nome:"Produto 3", Valor: 2m));
            produtos.Add(new Produtos(Codigo:3, Nome:"Produto 4", Valor: 2m));
            produtos.Add(new Produtos(Codigo:4, Nome:"Produto 5", Valor: 2m));
            produtos.Add(new Produtos(Codigo:5, Nome:"Produto 6", Valor: 2m));
            
            var valorEsperado = 16m;
            var valor = imposto.Calcular(produtos);

            valor.Should().Be(valorEsperado);

        }

        [Fact]
        public void Deve_incidir_cinco_reais_mais_dez_reais_de_impostos_acima_de_cinco_produtos_e_acima_de_cem_reais()
        {
            var imposto = new MeuImposto();
            var produtos = new List<Produtos>();

            produtos.Add(new Produtos(Codigo:0, Nome:"Produto 1", Valor: 50m));
            produtos.Add(new Produtos(Codigo:1, Nome:"Produto 2", Valor: 10m));
            produtos.Add(new Produtos(Codigo:2, Nome:"Produto 3", Valor: 10m));
            produtos.Add(new Produtos(Codigo:3, Nome:"Produto 4", Valor: 10m));
            produtos.Add(new Produtos(Codigo:4, Nome:"Produto 5", Valor: 20m));
            produtos.Add(new Produtos(Codigo:5, Nome:"Produto 6", Valor: 10m));
            
            var valorEsperado = 125m;
            var valor = imposto.Calcular(produtos);

            valor.Should().Be(valorEsperado);

        }


        /*
        Nao coberto
        [Fact]
        public void Deve_nao_incidir_imposto_com_valores_iguais_a_cem_reais()
        {
            var imposto = new MeuImposto();
            var produtos = new List<Produtos>();
            

            produtos.Add(new Produtos(Codigo:1, Nome:"Produto 1", Valor: 20m));
            produtos.Add(new Produtos(Codigo:2, Nome:"Produto 2", Valor: 20m));
            produtos.Add(new Produtos(Codigo:3, Nome:"Produto 3", Valor: 20m));
            produtos.Add(new Produtos(Codigo:4, Nome:"Produto 4", Valor: 20m));
            produtos.Add(new Produtos(Codigo:5, Nome:"Produto 5", Valor: 20m));
            
            var valorEsperado = 100m;
            var valor = imposto.Calcular(produtos);

            valor.Should().Be(valorEsperado);

        }
*/

    } 
}