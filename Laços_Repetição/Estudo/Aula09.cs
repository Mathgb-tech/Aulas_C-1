namespace Estudo;

public class Aula09
{
    public static void Executar()
    {
        Repositorio bancoDeDados = new Repositorio();

        Console.Write("Digite o nome do funcionario: ");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite o cargo do funcionario: ");
        string cargo = Console.ReadLine()!.Trim().ToLower();

        if(cargo == "desenvolvedor")
        {
            Console.Write("Digite o nome da linguagem que voce mais utiliza: ");
            string linguagem = Console.ReadLine()!.Trim().ToLower();

            Console.Write("Digite aqui o seu salario atual: ");
            string salarioEmString = Console.ReadLine()!;
            double salario = double.Parse(salarioEmString);

            Desenvolvedor desenvolvedorJunior = new Desenvolvedor(nome, salario, linguagem);

            desenvolvedorJunior.CalcularBonusDesenvolvedor();

            bancoDeDados.AdicionarFuncionarioAoBanco(desenvolvedorJunior);

            Funcionario ? encontrado = bancoDeDados.Buscar(nome);
           
            if (encontrado != null)
            {
                encontrado.ExibirDadosFuncionario(
                    $"Nome do funcionario: {encontrado.NomeFuncionario}",
                    $"Salario Final: {desenvolvedorJunior.SalarioFuncionario}",
                    $"Linguagem utilizada: {desenvolvedorJunior.LinguagemPrincipal}"
                );
            }
            else
            {
                Console.WriteLine("Funcionario nao encontrado!");
            }
        }
    }
}