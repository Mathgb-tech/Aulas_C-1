// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//List<string> listaDasBandas = new List<string>();
void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    string opcaoEscolhida;
    int opcaoEscolhidaNumerica;
    do
    { 
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("\nDigite 2 para mostrar todas as bandas");
        Console.WriteLine("\nDigite 3 para avaliar uma banda");
        Console.WriteLine("\nDigite 4 para exibir a média de uma banda");
        Console.WriteLine("\nDigite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        opcaoEscolhida = Console.ReadLine()!;
        opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1: RegistrarBandas();
                break;
            case 2: MostrarBandas();
                break;
            case 3:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 4:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case -1:
                Console.WriteLine("Tchau tchau :)");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    } while(opcaoEscolhidaNumerica != -1);
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloDasOpcao("Registro de bandas");
    string nomeBanda;
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    nomeBanda = Console.ReadLine()!.Trim().ToLower();
    //listaDasBandas.Add(nomeBanda);
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(0500);
    Console.WriteLine("Deseja registrar outra banda? (S/N)");
    string resposta = Console.ReadLine()!;
    while(resposta.ToLower() == "s")
    {
        Console.WriteLine("Digite o nome da banda que deseja registrar: ");
        nomeBanda = Console.ReadLine()!.Trim().ToLower();
        //listaDasBandas.Add(nomeBanda);
        bandasRegistradas.Add(nomeBanda, new List<int>());
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Thread.Sleep(0500);
        Console.WriteLine("Deseja registrar outra banda? (S/N)");
        resposta = Console.ReadLine()!;
    }
    Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    //ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloDasOpcao("Exibição de bandas registradas");
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    Thread.Sleep(0500);
    //ExibirOpcoesDoMenu();
}

void ExibirTituloDasOpcao(string titulo)
{
    Console.Clear();
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();


/*List<double> numerosLista = new List<double>();

void Tela()
{   
    string quantidadeNumerosString;
    double quantidadeNumeros;
    Console.WriteLine("Digite a quantidade de números que deseja inserir: ");
    quantidadeNumerosString = Console.ReadLine()!;
    quantidadeNumeros = double.Parse(quantidadeNumerosString);

    for(int i = 0; i < quantidadeNumeros; i++)
    {
        Console.WriteLine($"Digite o {i + 1}º número: ");
        double numero = double.Parse(Console.ReadLine()!);
        numerosLista.Add(numero);
    }
    SomaDosNumeros(numerosLista);
}

void SomaDosNumeros(List<double> numeros) 
{
    double soma = 0;
    foreach(double numero in numeros)
    {
        soma += numero;
    }
    Console.WriteLine($"A soma dos números é: {soma}");
}

Tela();*/

List<int> numerosLista = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

foreach (int numero in numerosLista)
{
    if (numero % 2 == 0) {
        Console.WriteLine(numero);
    }
}

