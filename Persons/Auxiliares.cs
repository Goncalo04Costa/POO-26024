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
                return true; // Indica que o auxiliar foi adicionado com sucesso
            }
            else
            {
                return false; // Indica que não foi possível adicionar o auxiliar devido ao limite atingido
            }
        }

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
                    return true; // Indica que o auxiliar foi removido com sucesso
                }
            }
            return false; // Indica que o auxiliar não foi encontrado para remoção
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



