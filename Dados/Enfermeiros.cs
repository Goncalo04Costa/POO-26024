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
    public class Enfermeiros
    {
        private  static List<Enfermeiro> enfermeirosList; 

        static Enfermeiros()
        {
            enfermeirosList = new List<Enfermeiro>(); // Inicializando a lista vazia
        }

        public Enfermeiros()
        {

        }

        /// <summary>
        /// Obtém uma cópia da lista de Enfermeiros.
        /// </summary>
        public List<Enfermeiro> EnfermeirosList
        {
            get { return new List<Enfermeiro>(enfermeirosList); }
        }

        /// <summary>
        /// Obtém o total atual de enfermeiros na lista.
        /// </summary>
        public int TotalEnfermeiros
        {
            get { return enfermeirosList.Count; }
        }

        /// <summary>
        /// Método estático para inserir um novo auxiliar na lista estática compartilhada.
        /// </summary>
        /// <param name="novoAuxiliar">O auxiliar a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereEnfermeiroLista(Enfermeiro novoEnfermeiro)
        {


            foreach (Enfermeiro aux in enfermeirosList)
            {
                if (aux.Equals(novoEnfermeiro))
                {
                    throw new EnfermeiroException("Já existe este enfermeiro na lista.");
                }
            }

            enfermeirosList.Add(novoEnfermeiro);
            return true;

        }

        /// <summary>
        /// Verifica se um enfermeiro com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do auxiliar a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public bool ExisteEnfermeiro(int codigoenfermeiro)
        {
            return enfermeirosList.Any(a => a.CodigoEnfermeiro == codigoenfermeiro);
        }


        /// <summary>
        /// Remove um auxiliar com base no seu código.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do auxiliar a ser removido.</param>
        /// <returns>True se o auxiliar foi removido com sucesso, False caso contrário.</returns>
        public bool RemoveEnfermeiro(int codigoenfermeiro)
        {
            Enfermeiro enfermeiro = enfermeirosList.Find(a => a.CodigoEnfermeiro == codigoenfermeiro);
            if (enfermeiro != null)
            {
                enfermeirosList.Remove(enfermeiro);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LerEnfermeiros(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    enfermeirosList = (List<Enfermeiro>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroEnfermeiroException("Erro ao ler o ficheiro de enfermeiros: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GravarEnfermeiros(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, enfermeirosList);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiroEnfermeirosException e)
            {
                throw new EscritaFicheiroEnfermeirosException("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }

        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de auxiliares.
        /// </summary>
        /// <returns>Uma lista contendo todos os auxiliares.</returns>
        public static List<Enfermeiro> EnviarTodosEnfermeiros()
        {
            return enfermeirosList.ToList();
        }

        /// <summary>
        /// Retorna o número total de auxiliares na lista.
        /// </summary>
        /// <returns>O número total de auxiliares.</returns>
        public int ContaEnfermeiros()
        {
            return enfermeirosList.Count;
        }
    }
}
