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
    /// Representa a coleção de objetos Enfermeiro.
    /// </summary>
    public class Enfermeiros
    {
        private Enfermeiro[] enfermeirosArray;
        private const int MAX_ENFERMEIROS = 24;
        private int totalEnfermeiros;

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
        /// Obtém uma cópia do array de Enfermeiros.
        /// </summary>
        public Enfermeiro[] EnfermeirosArray
        {
            get { return (Enfermeiro[])enfermeirosArray.Clone(); }
            set { } 
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
        public bool AdicionarEnfermeiro(Enfermeiro enfermeiro)
        {
            if (totalEnfermeiros < MAX_ENFERMEIROS)
            {
                enfermeirosArray[totalEnfermeiros] = enfermeiro;
                totalEnfermeiros++;
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public bool RemoverEnfermeiro(int codigoEnfermeiro)
        {
            for (int i = 0; i < totalEnfermeiros; i++)
            {
                if (enfermeirosArray[i].CodigoEnfermeiro == codigoEnfermeiro)
                {
                    for (int j = i; j < totalEnfermeiros - 1; j++)
                    {
                        enfermeirosArray[j] = enfermeirosArray[j + 1];
                    }
                    enfermeirosArray[totalEnfermeiros - 1] = null;
                    totalEnfermeiros--;
                    ;
                    return true; 
                }
            }
            
            return false; 
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
