/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

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

        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LeFuncionarios()
        {
            if (!(File.Exists("Funcionarios.bin"))) return false;
            Stream s = File.Open("Funcionarios.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            funcionariosList = (List<Funcionario>)b.Deserialize(s);
            s.Close();
            return true;
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaFuncionario()
        {
            if (!(File.Exists("Funcionarios.bin"))) return false;
            Stream s = File.Open("Funcionarios.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, funcionariosList);
            s.Close();
            return true;
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
