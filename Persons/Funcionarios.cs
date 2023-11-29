/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;

namespace Persons
{
    /// <summary>
    /// A classe Funcionarios gerencia uma lista de funcionários.
    /// </summary>
    public class Funcionarios
    {
        private List<Funcionario> funcionariosList; // Utilizando List<Funcionario> em vez de Funcionario[]

        public Funcionarios()
        {
            funcionariosList = new List<Funcionario>(); // Inicializando a lista vazia
        }

        public List<Funcionario> FuncionariosList
        {
            get { return funcionariosList; }
        }

        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            funcionariosList.Add(funcionario); // Adicionando o funcionário à lista
            return true; // Sempre pode adicionar, não há um limite fixo
        }

        public bool RemoverFuncionario(int nif)
        {
            Funcionario funcionarioParaRemover = funcionariosList.Find(f => f.Nif == nif);
            if (funcionarioParaRemover != null)
            {
                funcionariosList.Remove(funcionarioParaRemover); // Removendo o funcionário da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return new List<Funcionario>(funcionariosList); // Retorna uma nova lista com os funcionários
        }

        public int ContaFuncionarios()
        {
            return funcionariosList.Count; // Contando o número de funcionários na lista
        }
    }
}
