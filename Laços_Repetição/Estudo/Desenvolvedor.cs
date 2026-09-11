using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Estudo
{
    
    public class Desenvolvedor:Funcionario
    {
        public string linguagemPrincipal {get; private set;}

        public float salarioFinalDesenvolvedor {get;  set;}

        public float bonusDesenvolvedor {get;  set;}

        public Desenvolvedor(string nome, float salario,string linguagem): base(nome, salario)
        {
            linguagemPrincipal = linguagem;
        }

        public double CalcularBonusDesenvolvedor()
        {
            bonusDesenvolvedor = 10 * salarioFuncionario / 100;

            salarioFinalDesenvolvedor = salarioFuncionario + bonusDesenvolvedor;

            return salarioFinalDesenvolvedor;
        }
    }
}