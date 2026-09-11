using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Estudo
{
   public class Gerente:Funcionario
    {
        public string departamentoGerente {get; private set;}
        public float salarioFinalGerente {get;  set;}

        public float bonusGerente {get;  set;}

        public Gerente(string nome, float salario,string departamento):base(nome, salario)
        {
            departamentoGerente = departamento;
        }

        public double CalcularBonusDoGerente()
        {
            bonusGerente = 20 * salarioFuncionario / 100;

            salarioFinalGerente = salarioFuncionario + bonusGerente;

            return salarioFinalGerente;
        }
    }
}