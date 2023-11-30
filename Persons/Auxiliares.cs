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

namespace Persons
{
    /// <summary>
    /// Representa uma classe que gerencia uma lista dinâmica de objetos Auxiliar.
    /// </summary>
    public class Auxiliares
    {
        private List<Auxiliar> auxiliaresList;

        /// <summary>
        /// Construtor padrão que inicializa a lista de auxiliares.
        /// </summary>
        public Auxiliares()
        {
            auxiliaresList = new List<Auxiliar>();
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
        /// Adiciona um auxiliar à lista.
        /// </summary>
        /// <param name="auxiliar">O auxiliar a ser adicionado.</param>
        public void AdicionarAuxiliar(Auxiliar auxiliar)
        {
            auxiliaresList.Add(auxiliar);
        }

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
        public bool LeAuxiliares()
        {
            if (!(File.Exists("Auxiliares.bin"))) return false;
            Stream s = File.Open("Auxiliares.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            auxiliaresList = (List<Auxiliar>)b.Deserialize(s);
            s.Close();
            return true;
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaConsultas()
        {
            if (!(File.Exists("Auxiliares.bin"))) return false;
            Stream s = File.Open("Auxiliares.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, auxiliaresList);
            s.Close();
            return true;
        }

        /// <summary>
        /// Retorna uma lista contendo os auxiliares atualmente armazenados.
        /// </summary>
        /// <returns>Uma lista de objetos Auxiliar.</returns>
        public List<Auxiliar> ListarAuxiliares()
        {
            return new List<Auxiliar>(auxiliaresList);
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
