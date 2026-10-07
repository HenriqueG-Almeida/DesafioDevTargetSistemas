using System;
using System.Globalization;

namespace CalculoJuros.Utilities
{
    public static class InputData
    {
        public static DateTime GetDataVencimento()
        {
            while (true)
            {
                Console.Write("Insira a data de vencimento (dd/MM/yyyy): ");
                string? entrada = Console.ReadLine();

                bool dataValida = DateTime.TryParseExact(
                    entrada,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime dataVencimento
                );

                if (dataValida)
                {
                    return dataVencimento;
                }

                Console.WriteLine(
                    "Data inválida. Digite uma data válida, como 07/10/2026."
                );
            }
        }

        public static double GetDataValor()
        {
            while (true)
            {
                Console.Write("Insira o valor da dívida: ");
                string? entrada = Console.ReadLine();

                bool valorValido = double.TryParse(entrada, out double valorDivida);

                if (valorValido)
                {
                    return valorDivida;
                }

                Console.WriteLine("Valor inválido. Digite um valor numérico válido.");
            }
        }
    }
}