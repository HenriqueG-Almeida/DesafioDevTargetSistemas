using ControleEstoque.Model;
using System.Text.Json;

namespace ControleEstoque.Repos;

public class GravadorEstoque
{
    public void SalvarProdutos(List<Produto> produtos, string caminho)
    {
        string json = JsonSerializer.Serialize(
            new { estoque = produtos },
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            }
        );

        File.WriteAllText(caminho, json);
    }
}
