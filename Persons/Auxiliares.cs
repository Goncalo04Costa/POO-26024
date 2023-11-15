﻿/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */


namespace Persons
{
    /// <summary>
    /// Representa uma classe que gerencia um array de objetos Auxiliar.
    /// </summary>
    public class Auxiliares
    {
        private Auxiliar[] auxiliaresArray;
        private const int MAX_AUXILIARES = 52;
        private int totalAuxiliares;

        /// <summary>
        /// Construtor padrão que inicializa um array de auxiliares e define o total de auxiliares como 0.
        /// </summary>
        public Auxiliares()
        {
            auxiliaresArray = new Auxiliar[MAX_AUXILIARES];
            totalAuxiliares = 0;
        }

        /// <summary>
        /// Obtém o número máximo de auxiliares permitidos.
        /// </summary>
        public static int MaxAuxiliares { get { return MAX_AUXILIARES; } }



        /// <summary>
        /// Obtém uma cópia do array de Auxiliares.
        /// </summary>
        public Auxiliar[] AuxiliarArray
        {
            get { return (Auxiliar[])AuxiliarArray.Clone(); }
            set { }
        }



        /// <summary>
        /// Obtém o total atual de auxiliares no array.
        /// </summary>
        public int TotalAuxiliares
        {
            get { return totalAuxiliares; }
        }

        #region Outros Métodos

        /// <summary>
        /// Adiciona um auxiliar ao array, desde que o limite máximo não tenha sido atingido.
        /// </summary>
        /// <param name="auxiliar">O auxiliar a ser adicionado.</param>
        public bool AdicionarAuxiliar(Auxiliar auxiliar)
        {
            if (totalAuxiliares < MAX_AUXILIARES)
            {
                auxiliaresArray[totalAuxiliares] = auxiliar;
                totalAuxiliares++;
                return true; 
            }
            else
            {
                return false; 
            }
        }


        /// <summary>
        /// Remove um Auxiliar com base no seu código.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do Auxiliar a ser removido.</param>
        /// <returns>True se o Auxiliar foi removido com sucesso, False caso contrário.</returns>
        public bool RemoverAuxiliar(int codigoAuxiliar)
        {
            for (int i = 0; i < totalAuxiliares; i++)
            {
                if (auxiliaresArray[i].CodigoAuxiliar == codigoAuxiliar)
                {
                    for (int j = i; j < totalAuxiliares - 1; j++)
                    {
                        auxiliaresArray[j] = auxiliaresArray[j + 1];
                    }
                    auxiliaresArray[totalAuxiliares - 1] = null;
                    totalAuxiliares--;
                    return true; 
                }
            }
            return false; 
        }
        /// <summary>
        /// Retorna um array contendo os auxiliares atualmente armazenados.
        /// </summary>
        /// <returns>Um array de objetos Auxiliar.</returns>
        public Auxiliar[] ListarAuxiliares()
        {
            Auxiliar[] arrayAuxiliares = new Auxiliar[totalAuxiliares];

            for (int i = 0; i < totalAuxiliares; i++)
            {
                arrayAuxiliares[i] = auxiliaresArray[i];
            }

            return arrayAuxiliares;
        }

        /// <summary>
        /// Retorna o número total de auxiliares no array.
        /// </summary>
        public int ContaAuxiliares()
        {
            return totalAuxiliares;
        }

        #endregion
    }
}



