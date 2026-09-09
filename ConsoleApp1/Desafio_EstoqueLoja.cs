namespace Atividade_ConsoleApp1
{
    public class Desafio_EstoqueLoja
    {
        public static void Executar()
        {
            Dictionary<string, int> nomeProdutos = new Dictionary<string, int>
            {
              {"Arroz", 10},
              {"Feijao", 20},
              {"Macarrão", 5}  
            };

            foreach (string produto in nomeProdutos.Keys)
            {
                Console.WriteLine($"Produto: {produto}");
                Console.WriteLine($"Quantidade em estoque: {nomeProdutos[produto]}");
            }
        }
    }
}