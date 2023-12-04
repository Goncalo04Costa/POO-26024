/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */


using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ObjetosdeNegocio;
using Excecao;
using Interfaces;

namespace Dados
{
    /// <summary>
    /// Representa uma classe que gerencia uma lista dinâmica de objetos Auxiliar.
    /// </summary>
    public class Auxiliares
    {
        private static List<Auxiliar> auxiliaresList;

        /// <summary>
        /// Construtor padrão que inicializa a lista de auxiliares.
        /// </summary>
        static Auxiliares()
        {
            auxiliaresList = new List<Auxiliar>();
        }


        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public Auxiliares()
        {

        }

        /// <summary>
        /// Obtém uma cópia da lista de Auxiliares.
        /// </summary>
        public List<Auxiliar> AuxiliarList
        {
            get { return new List<Auxiliar>(auxiliaresList); }
        }

        /// <summary>
        /// Obtém o total atual de auxiliares na lista.
        /// </summary>
        public int TotalAuxiliares
        {
            get { return auxiliaresList.Count; }
        }

        #region Outros Métodos

        /// <summary>
        /// Método estático para inserir um novo auxiliar na lista estática compartilhada.
        /// </summary>
        /// <param name="novoAuxiliar">O auxiliar a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereAuxiliarLista(Auxiliar novoAuxiliar)
        {
            
            
                foreach (Auxiliar aux in auxiliaresList)
                {
                    if (aux.Equals(novoAuxiliar))
                    {
                        throw new AuxiliarException("Já existe este auxiliar na lista.");
                    }
                }

                auxiliaresList.Add(novoAuxiliar);
                return true; 
            
        }

        /// <summary>
        /// Verifica se um auxiliar com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do auxiliar a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public bool ExisteAuxiliar(int codigoAuxiliar)
        {
            return auxiliaresList.Any(a => a.CodigoAuxiliar == codigoAuxiliar);
        }


        /// <summary>
        /// Remove um auxiliar com base no seu código.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do auxiliar a ser removido.</param>
        /// <returns>True se o auxiliar foi removido com sucesso, False caso contrário.</returns>
        public bool RemoverAuxiliar(int codigoAuxiliar)
        {
            Auxiliar auxiliar = auxiliaresList.Find(a => a.CodigoAuxiliar == codigoAuxiliar);
            if (auxiliar != null)
            {
                auxiliaresList.Remove(auxiliar);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LerAuxiliares(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    auxiliaresList = (List<Auxiliar>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroAuxiliarException("Erro ao ler o ficheiro de auxiliares: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GravarAuxiliares(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, auxiliaresList);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiroAuxiliaresException e)
            {
                throw new EscritaFicheiroAuxiliaresException("Erro ao gravar o ficheiro." + e.Message);
            }
           
            return true;
        }


        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de auxiliares.
        /// </summary>
        /// <returns>Uma lista contendo todos os auxiliares.</returns>
        public static List<Auxiliar> EnviarTodosAuxiliares()
        {
            return auxiliaresList.ToList();
        }

        /// <summary>
        /// Retorna o número total de auxiliares na lista.
        /// </summary>
        /// <returns>O número total de auxiliares.</returns>
        public int ContaAuxiliares()
        {
            return auxiliaresList.Count;
        }

        #endregion
    }
}
