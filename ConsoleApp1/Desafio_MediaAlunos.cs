
namespace Atividade_ConsoleApp1
{
    public class Desafio_MediaAlunos
    {
        public static void Executar()
        {
            Dictionary<string, List<double>> nomeAlunos = new Dictionary<string, List<double>>{
                {"Matheus", new List<double> {10.0, 7.5, 8.9}},
                {"Gabriel", new List<double> {10.0, 8.5, 8.9}},
                {"Nestor", new List<double>{10.0, 7.5, 8.0}}
            };

            foreach(string nome in nomeAlunos.Keys)
            {
                double media = 0;

                foreach(double notas in nomeAlunos[nome])
                {
                    media += notas;
                }
                media /= nomeAlunos[nome].Count;

                Console.WriteLine($"Aluno: {nome}");
                Console.WriteLine($"Media: {media}");
            }
        }
    }
}