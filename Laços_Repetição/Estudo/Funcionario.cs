using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Estudo
{
    public class Funcionario
    {
        public string NomeFuncionario { get; set; }
        public double SalarioFuncionario { get; set; }

        public Funcionario(string nome, double salario)
        {
            NomeFuncionario = nome;
            SalarioFuncionario = salario;
        }

        public void ExibirDadosFuncionario(params string[] textos)
        {
            foreach (string texto in textos)
                Console.WriteLine(texto);
        }
    }
}