/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

using System;

namespace Person
{
    /// <summary>
    /// Representa a coleção de objetos Enfermeiro.
    /// </summary>
    public class Enfermeiros
    {
        private Enfermeiro[] enfermeirosArray; // Array para armazenar objetos Enfermeiro
        private const int MAX_ENFERMEIROS = 24; // Número máximo de enfermeiros permitidos
        private int totalEnfermeiros; // Número atual de enfermeiros na coleção

        /// <summary>
        /// Construtor padrão para a classe Enfermeiros.
        /// Inicializa o array de Enfermeiro e define o número total de enfermeiros como zero.
        /// </summary>
        public Enfermeiros()
        {
            enfermeirosArray = new Enfermeiro[MAX_ENFERMEIROS];
            totalEnfermeiros = 0;
        }

        /// <summary>
        /// Obtém o número máximo de enfermeiros permitidos.
        /// </summary>
        public static int MaxEnfermeiros { get { return MAX_ENFERMEIROS; } }

        /// <summary>
        /// Obtém uma cópia do array de Enfermeiro.
        /// </summary>
        public Enfermeiro[] EnfermeirosArray
        {
            get { return (Enfermeiro[])enfermeirosArray.Clone(); }
            set { } // Evite definir o array diretamente para evitar modificações externas.
        }

        /// <summary>
        /// Obtém o número total de enfermeiros na coleção.
        /// </summary>
        public int TotalEnfermeiros
        {
            get { return totalEnfermeiros; }
        }

        #region Outros Métodos

        /// <summary>
        /// Adiciona um objeto Enfermeiro à coleção.
        /// </summary>
        /// <param name="enfermeiro">O objeto Enfermeiro a ser adicionado.</param>
        public void AdicionarEnfermeiro(Enfermeiro enfermeiro)
        {
            if (totalEnfermeiros < MAX_ENFERMEIROS)
            {
                enfermeirosArray[totalEnfermeiros] = enfermeiro;
                totalEnfermeiros++;
            }
            else
            {
                Console.WriteLine("O limite máximo de enfermeiros foi atingido. Não é possível adicionar mais enfermeiros.");
            }
        }

        /// <summary>
        /// Remove um objeto Enfermeiro da coleção com base no código do enfermeiro.
        /// </summary>
        /// <param name="codigoEnfermeiro">O código do Enfermeiro a ser removido.</param>
        public void RemoverEnfermeiro(int codigoEnfermeiro)
        {
            for (int i = 0; i < totalEnfermeiros; i++)
            {
                if (enfermeirosArray[i].CodigoEnfermeiro == codigoEnfermeiro)
                {
                    for (int j = i; j < totalEnfermeiros - 1; j++)
                    {
                        enfermeirosArray[j] = enfermeirosArray[j + 1];
                    }
                    enfermeirosArray[totalEnfermeiros - 1] = null; // Limpar a última posição
                    totalEnfermeiros--;
                    Console.WriteLine("Enfermeiro removido com sucesso.");
                    return;
                }
            }
            Console.WriteLine("Enfermeiro não encontrado.");
        }

        /// <summary>
        /// Conta e retorna o número total de enfermeiros na coleção.
        /// </summary>
        /// <returns>O número total de enfermeiros.</returns>
        public int ContarEnfermeiros()
        {
            return totalEnfermeiros;
        }

        #endregion
    }
}
