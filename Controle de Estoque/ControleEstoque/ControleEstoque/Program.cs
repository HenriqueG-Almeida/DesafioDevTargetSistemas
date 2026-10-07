using ControleEstoque.oprEstoque;
using ControleEstoque.Repos;

Console.WriteLine("Gerenciador de Estoque\n");

int opcao;
var produtos = LeitorEstoque.LeitorProdutos();

do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Listar estoque");
    Console.WriteLine("2 - Movimentar estoque");
    Console.WriteLine("3 - Sair");
    Console.Write("Opção: ");
    opcao = int.Parse(Console.ReadLine() ?? "0");
    switch (opcao)
    {
        case 1:
            LeitorEstoque.ExibirProdutos(produtos);
            break;
        case 2:
            MovimentaEstoque.MovimentarEstoque(produtos);
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 3);