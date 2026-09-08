List<string> listaDeCompras = new List<string>();

listaDeCompras.Add("Arroz");
listaDeCompras.Add("Feijão");
listaDeCompras.Add("Macarrão");

foreach (string item in listaDeCompras)
{
    Console.WriteLine(item);
}

listaDeCompras.Clear();

if(listaDeCompras.Count == 0)
{
    Console.WriteLine("A lista de compras está vazia.");
}

Console.WriteLine("Digite o nome de um produto: ");
string produto = Console.ReadLine()!;

listaDeCompras.Add(produto);

Console.WriteLine();

 void ExibirOpcoesDoMenu()
{
    string opcaoEscolhida;
    int opcaoEscolhidaNumerica;
    do
    {
        Console.WriteLine("1 - Adicionar produto à lista de compras");
        Console.WriteLine("2 - Exibir lista de compras");
        Console.WriteLine("3 - Limpar lista de compras");
        Console.WriteLine("4 - Sair");
        Console.Write("\nEscolha uma opção: ");
        opcaoEscolhida = Console.ReadLine()!;
        opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1: AdicionarProduto();
                break;
            case 2: ExibirListaDeCompras();
                break;
            case 3: LimparListaDeCompras();
                break;
            case 4:
                Console.WriteLine("Tchau tchau :)");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }while(opcaoEscolhidaNumerica != 4);
}

void MostrarListaDeCompras()
{
    Console.Clear();
    Console.WriteLine("Lista de compras:");
    foreach (string item in listaDeCompras)
    {
        Console.WriteLine(item);
    }

    if(listaDeCompras.Count == 0)
    {
        Console.WriteLine("A lista de compras está vazia.");
    }
    
}

void AdicionarProduto()
{
    Console.Clear();
    Console.WriteLine("Digite o nome do produto que deseja adicionar à lista de compras: ");
    string produto = Console.ReadLine()!;
    listaDeCompras.Add(produto);
    Console.WriteLine($"Produto {produto} adicionado à lista de compras.");
}

void LimparListaDeCompras()
{
    Console.Clear();
    listaDeCompras.Clear();
    Console.WriteLine("Lista de compras limpa.");
}

void ExibirLogo()
{
    Console.WriteLine(@"

ExibirOpcoesDoMenu();