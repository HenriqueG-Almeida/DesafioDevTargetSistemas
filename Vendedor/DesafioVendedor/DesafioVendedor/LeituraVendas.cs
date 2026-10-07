using System.Text.Json;

namespace DesafioVendedor;

public static class LeituraVendas
{
    public static List<Venda> LeitorVendas()
    {
        List<Venda> vendas = new List<Venda>();

        string caminho = Path.Combine("C:\\WorkSpace\\DesafioDev\\Vendedor\\DesafioVendedor\\DesafioVendedor", "Vendas.json");
        string json = File.ReadAllText(caminho);

        using JsonDocument documento = JsonDocument.Parse(json);

        foreach (var venda in documento.RootElement.GetProperty("vendas").EnumerateArray())
        {
            vendas.Add(new Venda
            {
                Vendedor = venda.GetProperty("vendedor").GetString() ?? string.Empty,
                Valor = venda.GetProperty("valor").GetDecimal()
            });
        }

        return vendas;
    }
}
