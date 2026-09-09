namespace Atividade_ConsoleApp1
{
    public class ScreenSound
    {
        public static void ExecutarPrograma()
        {
            // Screen Sound
            string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
            Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
            bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
            bandasRegistradas.Add("The Beatles", new List<int>());
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
                        case 1:
                            RegistrarBandas();
                            break;
                        case 2:
                            MostrarBandas();
                            break;
                        case 3:
                            AvaliarBanda();
                            break;
                        case 4:
                            MediaDasBandas();
                            break;
                        case -1:
                            Console.WriteLine("Tchau tchau :)");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                } while (opcaoEscolhidaNumerica != -1);
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
                while (resposta.ToLower() == "s")
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
                foreach (string banda in bandasRegistradas.Keys)
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

            void AvaliarBanda()
            {
                //Digitar qual banda deseja avaliar
                //Pesquiar / buscar a banda no dicionário
                //Se a banda existir no dicionario, iremos atribuir uma nota para a banda
                Console.Clear();
                ExibirLogo();
                string nomeBanda;
                int notaBanda;
                string notaBandaString;
                ExibirTituloDasOpcao("Avaliação de bandas");
                Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
                nomeBanda = Console.ReadLine()!.Trim().ToLower();

                if (!bandasRegistradas.ContainsKey(nomeBanda))
                {
                    Console.WriteLine($"A banda {nomeBanda} não foi encontrada.\n");
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }

                Console.WriteLine($"A banda {nomeBanda} foi encontrada, digite a nota que deseja dar para ela: ");
                notaBandaString = Console.ReadLine()!;
                notaBanda = int.Parse(notaBandaString);

                while (notaBanda < 0 || notaBanda > 5)
                {
                    Console.WriteLine("A nota deve ser entre 0 e 5. Por favor, tente novamente.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Console.WriteLine($"Digite a nota que deseja dar para a banda {nomeBanda} (entre 0 e 5): ");
                    notaBandaString = Console.ReadLine()!;
                    notaBanda = int.Parse(notaBandaString);
                }

                bandasRegistradas[nomeBanda].Add(notaBanda);
                Console.WriteLine($"A nota {notaBanda} fo i registrada com sucesso para a banda {nomeBanda}.\n");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal");
                Console.ReadKey();
                Thread.Sleep(0500);
                Console.Clear();
            }

            void MediaDasBandas()
            {
                //Digitar qual banda deseja ver a média
                //Pesquisar / buscar a banda no dicionário
                //Se a banda existir no dicionario, iremos calcular a media das notas da banda
                Console.Clear();
                ExibirLogo();
                string nomeBanda;
                double mediaDasNotas = 0;
                ExibirLogo();
                ExibirTituloDasOpcao("Média das bandas");

                Console.WriteLine("Digite o nome da banda que deseja ver a média: ");
                nomeBanda = Console.ReadLine()!.Trim().ToLower();
                if (!bandasRegistradas.ContainsKey(nomeBanda))
                {
                    Console.WriteLine($"A banda {nomeBanda} não foi encontrada.\n");
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                foreach (int nota in bandasRegistradas[nomeBanda])
                {
                    mediaDasNotas += nota;
                }
                mediaDasNotas /= bandasRegistradas[nomeBanda].Count;
                Console.WriteLine($"A média das notas da banda {nomeBanda} é: {mediaDasNotas:F2}");
            }


            ExibirOpcoesDoMenu();

        }
    }
}