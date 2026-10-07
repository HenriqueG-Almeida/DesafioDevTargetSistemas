using ControleEstoque.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.oprEstoque
{
    public static class MovimentaEstoque
    {
        static MovimentacoesEstoque movimentacoes = new MovimentacoesEstoque();
        public static void MovimentarEstoque(List<Produto> produtos)
        {
            Produto produto = new Produto();
            do
            {
                Console.WriteLine("=== Movimentação de Estoque ===\n"   );
                Console.WriteLine("1. Acrecentar estoque"               );
                Console.WriteLine("2. Retirar estoque"                  );
                Console.WriteLine("3. Voltar ao menu principal"         );
                Console.Write("Escolha uma opção: "                     );
                string? opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        produto = movimentacoes.RetornaProduto(produtos);

                        if (produto != null)
                        {
                            movimentacoes.ExibirProduto(produto);
                            movimentacoes.AcrescentaEstoque(produto, movimentacoes.InputNumeroMovimenta(), produtos);
                        }
                        break;
                    case "2":
                        produto = movimentacoes.RetornaProduto(produtos);
                        if (produto != null)
                        {
                            movimentacoes.ExibirProduto(produto);
                            movimentacoes.RetiraEstoque(produto, movimentacoes.InputNumeroMovimenta(), produtos);
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (true);
        }
    }
}