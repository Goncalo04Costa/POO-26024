/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using Excecao;
using ObjetosdeNegocio;

namespace Dados
{
    /// <summary>
    /// A classe Funcionarios gerencia uma lista de funcionários.
    /// </summary>
    public class Funcionarios
    {
        private static List<Funcionario> funcionariosList; 

        static Funcionarios()
        {
            funcionariosList = new List<Funcionario>(); 
        }

        public Funcionarios()
        { 
        
        }

        /// <summary>
        /// Método estático para inserir um novo funcionario na lista estática compartilhada.
        /// </summary>
        /// <param name="novofunc">O funcionario a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereFuncionarioLista(Funcionario novofunc)
        {


            foreach (Funcionario aux in funcionariosList)
            {
                if (aux.Equals(novofunc))
                {
                    throw new FuncionarioException("Já existe este funcionario na lista.");
                }
            }

            funcionariosList.Add(novofunc);
            return true;

        }

        /// <summary>
        /// Verifica se um funcionario com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="codigofunc">O código do funcionario a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public bool ExisteFuncionario(int codigofunc)
        {
            return funcionariosList.Any(a => a.Codigo == codigofunc);
        }


        /// <summary>
        /// Remove um funcionario com base no seu código.
        /// </summary>
        /// <param name="cod">O código do funcionario a ser removido.</param>
        /// <returns>True se o funcionario foi removido com sucesso, False caso contrário.</returns>
        public bool RemoveFunc(int cod)
        {
            Funcionario funcionario = funcionariosList.Find(a => a.Codigo == cod);
            if (funcionario != null)
            {
                funcionariosList.Remove(funcionario);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LerFuncionario(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    funcionariosList = (List<Funcionario>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroFuncionarioException("Erro ao ler o ficheiro de funcionarios: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GravarFuncionarios(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, funcionariosList);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiroFuncionariosException e)
            {
                throw new EscritaFicheiroFuncionariosException("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }

        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de funcionarios.
        /// </summary>
        /// <returns>Uma lista contendo todos os funcionarios.</returns>
        public static List<Funcionario> EnviarTodosFuncionarios()
        {
            return funcionariosList.ToList();
        }

        /// <summary>
        /// Retorna o número total de funcionarios na lista.
        /// </summary>
        /// <returns>O número total de funcionarios.</returns>
        public int Contafunc()
        {
            return funcionariosList.Count;
        }

    }
}
