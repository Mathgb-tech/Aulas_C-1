using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Estudo
{
    
    public class Desenvolvedor : Funcionario
{
    public string LinguagemPrincipal { get; private set; }

    public Desenvolvedor(string nome, double salario, string linguagem)
        : base(nome, salario)
    {
        LinguagemPrincipal = linguagem;
    }

    public double CalcularBonusDesenvolvedor()
    {
        SalarioFuncionario *= 0.10;
        return SalarioFuncionario;
    }
}
}