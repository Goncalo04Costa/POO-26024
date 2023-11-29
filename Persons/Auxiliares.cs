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
