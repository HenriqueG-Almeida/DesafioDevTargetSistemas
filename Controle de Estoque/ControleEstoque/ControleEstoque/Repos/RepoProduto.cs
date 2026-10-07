using ControleEstoque.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque
{
    public class RepoProduto
    {
        public int RetornaCodigoProduto(List<Produto> produtos, int codigoProduto)
        {
            Produto? produto = produtos.Find(p => p.CodigoProduto == codigoProduto);
            if (produto == null)
            {
                return 0;
            }
            return produto.CodigoProduto;
        }

        public Produto RetornaProdutoPorCodigo (List<Produto> produtos, int codigoProduto)
        {
            Produto? produto = produtos.Find(p => p.CodigoProduto == codigoProduto);
            if (produto == null)
            {
                return null;
            }
            return produto;
        }

    }
}
