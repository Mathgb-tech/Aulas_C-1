namespace Estudo;

public class Aula09
{
   public static void Executar()
    {
        Gerente gerente = new Gerente("Marcelo", 5000f, "Tester");
        Desenvolvedor desenvolvedor = new Desenvolvedor("Matheus", 2500f, "C#");

        gerente.ExibirDadosFuncionario();
        desenvolvedor.ExibirDadosFuncionario();

        gerente.CalcularBonusDoGerente();
        desenvolvedor.CalcularBonusDesenvolvedor();

        Console.WriteLine($"Bonus do gerente: {gerente.bonusGerente}, salario final: {gerente.salarioFinalGerente}");
    }
}