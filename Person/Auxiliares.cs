/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */


namespace Person
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
        /// Obtém uma cópia do array de auxiliares.
        /// </summary>
        public Auxiliar[] AuxiliaresArray
        {
            get { return (Auxiliar[])auxiliaresArray.Clone(); }
            set { } // EVITAR!
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
        public void AdicionarAuxiliar(Auxiliar auxiliar)
        {
            if (totalAuxiliares < MAX_AUXILIARES)
            {
                auxiliaresArray[totalAuxiliares] = auxiliar;
                totalAuxiliares++;
            }
            else
            {
                Console.WriteLine("O limite máximo de auxiliares foi atingido. Não é possível adicionar mais auxiliares.");
            }
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



