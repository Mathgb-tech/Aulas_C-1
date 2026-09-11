using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Estudo
{
    public class Funcionario
    {
        public string nomeFuncionario {get;  set;}
        public float salarioFuncionario {get;  set;}
        public Funcionario(string nome, float salario)
        {
            nomeFuncionario = nome;
            salarioFuncionario = salario;
        }

        public void ExibirDadosFuncionario()
        {
            Console.Write($"Nome do funcionario: {nomeFuncionario}");
            Console.WriteLine($"Salario do funcionario: {salarioFuncionario}");
        }
    }
}