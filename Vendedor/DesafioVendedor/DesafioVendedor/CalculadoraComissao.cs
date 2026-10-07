namespace DesafioVendedor;

public static class CalculadoraComissao
{
    public static decimal RetornaComissão(decimal valor)
    {
        if (valor >= 100 && valor < 500)
        {
            return valor * 0.01m;
        }

        if (valor >= 500)
        {
            return valor * 0.05m;
        }

        return 0m;
    }
}
