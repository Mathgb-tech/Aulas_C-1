using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Estudo
{
    public class Repositorio
    {
        private Dictionary<string, Funcionario> bancoDeDadosFuncionario = new Dictionary<string, Funcionario>();

        
        //Metodo que recebe um objeto do tipo funcionario e adiciona dentro do banco.
        public void AdicionarFuncionarioAoBanco(Funcionario funcionario)
        {
            //Fazemos antes de adicionar no banco uma busca para ver se os dados estao repetidos!
            if (bancoDeDadosFuncionario.ContainsKey(funcionario.NomeFuncionario))
            {
                throw new InvalidOperationException("Este usuario ja existe! Dados nao podem ser reatribuidos no sistema!");
            }

            bancoDeDadosFuncionario.Add(funcionario.NomeFuncionario, funcionario);
        }

        //Esse metodo que retorna um valor do tipo funcionario visa buscar funcionarios dentro do banco recebendo como parametro o nome. Usamos o trygetvalua para ele devolver o objeto de volta. o metodo containsKey da classe dictionary apenas retorna um valor booleano (true ou false).
        public Funcionario ? Buscar(string nome)
        {
            bancoDeDadosFuncionario.TryGetValue(nome, out Funcionario encontrado);
            return encontrado;
        }

        public bool Remover(string nome)
        {
            return bancoDeDadosFuncionario.Remove(nome);
        }

        public List<Funcionario> ListarTodos()
        {
            return bancoDeDadosFuncionario.Values.ToList();
        }
    }
}