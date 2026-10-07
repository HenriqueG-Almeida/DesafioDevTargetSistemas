using CalculoJuros.Utilities;

Console.WriteLine("Calculo de Juros\n");

int opt = 1;

Console.WriteLine("Calculo de Juros Simples de 2.5% por dia a partir da data de vencimento\n");

do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Calcular juros");
    Console.WriteLine("2 - Sair");

    opt = Convert.ToInt32(Console.ReadLine());

    switch (opt)
    {
        case 1:
            double valorDivida = InputData.GetDataValor();
            DateTime dataVencimento = InputData.GetDataVencimento();
            TimeSpan diferencaDias = DateTime.Now - dataVencimento;
            int diasAtraso = diferencaDias.Days;
            if (diasAtraso > 0)
            {
                double jurosSimples = valorDivida * 0.025 * diasAtraso;
                double valorTotal = valorDivida + jurosSimples;
                Console.WriteLine($"Valor da dívida: {valorDivida:C}");
                Console.WriteLine($"Dias de atraso: {diasAtraso}");
                Console.WriteLine($"Juros simples: {jurosSimples:C}");
                Console.WriteLine($"Valor total a pagar: {valorTotal:C}");
                break;
            }
            else
            {
                Console.WriteLine("Não houve atraso no pagamento. Nenhum juros será aplicado.");
                break;
            }
        case 2:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}while (opt != 2);