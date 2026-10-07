namespace DesafioVendedor;

public class RelatorioVendas
{
    public static void RetornaVendas(List<Venda> vendas)
    {
        foreach (var venda in vendas)
        {
            Console.WriteLine($"{venda.Vendedor}: {venda.Valor} Comissão: {CalculadoraComissao.RetornaComissão(venda.Valor)}");
        }
    }
}
