using ControleEstoque.Model;
using System.Text.Json;

namespace ControleEstoque.Repos
{
    public static class LeitorEstoque
    {
        public static List<Produto> LeitorProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            string caminho = Path.Combine("C:\\WorkSpace\\DesafioDev\\Controle de Estoque\\ControleEstoque\\ControleEstoque", "Estoque.json");
            string json = File.ReadAllText(caminho);

            using JsonDocument documento = JsonDocument.Parse(json);

            foreach (var produto in documento.RootElement.GetProperty("estoque").EnumerateArray())
            {
                produtos.Add(new Produto
                {
                    CodigoProduto = produto.GetProperty("codigoProduto").GetInt32(),
                    DescricaoProduto = produto.GetProperty("descricaoProduto").GetString() ?? string.Empty,
                    Estoque = produto.GetProperty("estoque").GetInt32()
                });
            }

            return produtos;
        }
        public static void ExibirProdutos(List<Produto> produtos)
        {
            Console.WriteLine("Produtos em estoque:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Código: {produto.CodigoProduto}, Descrição: {produto.DescricaoProduto}, Estoque: {produto.Estoque}\n");
            }
        }
    }
}
