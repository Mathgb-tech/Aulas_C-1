namespace Atividade_ConsoleApp1
{
    public class Desafio_VendaCarros
    {
        public static void Executar()
        {
            Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
                { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
                { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
                { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
                { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
                { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
            };
            int media = 0;
            foreach (string carros in vendasCarros.Keys)
            {
                Console.WriteLine($"{carros}");
            }
            Console.WriteLine("Digite o nome do carro que deseja ver as vendas: ");
            string carro = Console.ReadLine()!;

            if(!vendasCarros.ContainsKey(carro))
            {
                Console.WriteLine("Este carro nao existe!");
                return;
            }

            foreach (int vendas in vendasCarros[carro])
            {
                
               media += vendas;
            }
                media /= vendasCarros[carro].Count;
                Console.WriteLine(media);
        }
    }
}