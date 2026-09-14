using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Estudo
{
   public class Gerente:Funcionario
    {
        public string departamentoGerente {get; private set;}

        public Gerente(string nome, double salario, string departamento):base(nome, salario)
        {
            departamentoGerente = departamento;
        }

        public double CalcularBonusDoGerente()
        {
            SalarioFuncionario *= 0.20;
            return SalarioFuncionario;
        }
    }
}