using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using DesafioVendedor;

Console.WriteLine("Calculo de comissão de vendas\n");

RelatorioVendas.RetornaVendas(LeituraVendas.LeitorVendas());

Console.ReadLine();