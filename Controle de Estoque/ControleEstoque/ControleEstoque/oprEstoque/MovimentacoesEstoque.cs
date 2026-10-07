using ControleEstoque.Model;
using ControleEstoque.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.oprEstoque
{
    public class MovimentacoesEstoque
    {
        GravadorEstoque gravador = new GravadorEstoque();
        RepoProduto repoProduto = new RepoProduto();
        public Produto AcrescentaEstoque(Produto produto, decimal valorAcrescimo, List<Produto> produtos)
        {
            produto.Estoque += (int)valorAcrescimo;
            gravador.SalvarProdutos(produtos, "produtos.json");

            return produto;
        }

        public Produto RetiraEstoque(Produto produto, decimal valorAcrescimo, List<Produto> produtos)
        {
            produto.Estoque -= (int)valorAcrescimo;
            gravador.SalvarProdutos(produtos, "produtos.json");
            return produto;
        }

        public Produto RetornaProduto(List<Produto> produtos)
        {
            var codigoProduto = InputCodProduto();

            codigoProduto = repoProduto.RetornaCodigoProduto(produtos, codigoProduto);
            Produto produto = repoProduto.RetornaProdutoPorCodigo(produtos, codigoProduto);

            if (codigoProduto == 0)
            {
                Console.WriteLine("Produto não encontrado.");
                return null;
            }
            return produto;
        }

        public int InputNumeroMovimenta()
        {
            int valorAcrescimo;
            while (true)
            {
                Console.Write("Digite a quantidade a movimentar: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out valorAcrescimo) && valorAcrescimo > 0)
                {
                    return valorAcrescimo;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro positivo.");
                }
            }
        }

        public int InputCodProduto()
        {
            int valorAcrescimo;
            while (true)
            {
                Console.Write("Digite o código do produto: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out valorAcrescimo) && valorAcrescimo > 0)
                {
                    return valorAcrescimo;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro positivo.");
                }
            }
        }

        public void ExibirProduto(Produto produto)
        {
            Console.WriteLine($"Código: {produto.CodigoProduto}, Descrição: {produto.DescricaoProduto}, Estoque: {produto.Estoque}\n");
        }
    }
}
