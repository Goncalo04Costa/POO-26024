/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace Persons
{
    /// <summary>
    /// Classe responsável por gerenciar um conjunto de Utentes.
    /// </summary>
    public class Utentes
    {
        private Utente[] utentesArray; 
        private const int MAX_UTENTES = 52; 
        private int totalUtentes; 

        /// <summary>
        /// Construtor padrão da classe Utentes.
        /// </summary>
        public Utentes()
        {
            utentesArray = new Utente[MAX_UTENTES]; 
            totalUtentes = 0; 
        }

        /// <summary>
        /// Propriedade estática somente leitura que retorna o número máximo de Utentes.
        /// </summary>
        public static int MaxUtentes { get { return MAX_UTENTES; } }

        /// <summary>
        /// Propriedade de leitura do array de Utentes (clone para evitar alterações externas).
        /// </summary>
        public Utente[] UtentesArray
        {
            get { return (Utente[])utentesArray.Clone(); }
            set { } 
        }

        /// <summary>
        /// Propriedade de leitura do total de Utentes.
        /// </summary>
        public int TotalUtentes
        {
            get { return totalUtentes; }
        }

        /// <summary>
        /// Adiciona um Utente ao array na próxima posição disponível.
        /// </summary>
        /// <param name="utente">O Utente a ser adicionado.</param>
        /// <returns>True se o Utente foi adicionado com sucesso, False caso contrário.</returns>
        public bool AdicionarUtente(Utente utente)
        {
            if (totalUtentes < MAX_UTENTES)
            {
                utentesArray[totalUtentes] = utente; 
                totalUtentes++;
                return true; 
            }
            else
            {
                
                return false; 
            }
        }

        /// <summary>
        /// Remove um Utente com base no NIF.
        /// </summary>
        /// <param name="NIF">O NIF do Utente a ser removido.</param>
        /// <returns>True se o Utente foi removido com sucesso, False caso contrário.</returns>
        public bool RemoverUtente(int NIF)
        {
            for (int i = 0; i < totalUtentes; i++)
            {
                if (utentesArray[i].Nif == NIF)
                {
                    for (int j = i; j < totalUtentes - 1; j++)
                    {
                        utentesArray[j] = utentesArray[j + 1];
                    }
                    utentesArray[totalUtentes - 1] = null;
                    totalUtentes--;
                    return true;
                }
            }

            return false; 
        }

        /// <summary>
        /// Obtém o número total de Utentes.
        /// </summary>
        /// <returns>O número total de Utentes.</returns>
        public int ContarUtentes()
        {
            return totalUtentes;
        }
    }
}
