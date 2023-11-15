/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */
namespace Product
{
    /// <summary>
    /// Classe que gerencia um conjunto de produtos de limpeza.
    /// </summary>
    public class Limpezas
    {
        private Limpeza[] limpezasArray;
        private const int MAX_limpeza = 200;
        private int totalprodutolimpeza;

        /// <summary>
        /// Construtor padrão que inicializa um array de produtos de limpeza e define o total como 0.
        /// </summary>
        public Limpezas()
        {
            limpezasArray = new Limpeza[MAX_limpeza];
            totalprodutolimpeza = 0;
        }

        /// <summary>
        /// Obtém o número máximo de produtos de limpeza permitidos.
        /// </summary>
        public static int MaxProdutoLimpeza { get { return MAX_limpeza; } }

        /// <summary>
        /// Obtém uma cópia do array de produtos de limpeza.
        /// </summary>
        public Limpeza[] LimpezasArray
        {
            get { return (Limpeza[])limpezasArray.Clone(); }
            set { }
        }

        /// <summary>
        /// Obtém o total atual de produtos de limpeza no array.
        /// </summary>
        public int TotalprodutoLimpeza
        {
            get { return totalprodutolimpeza; }
        }

        #region Outros Métodos

        /// <summary>
        /// Adiciona um produto de limpeza ao array, desde que o limite máximo não tenha sido atingido.
        /// </summary>
        /// <param name="limpeza">O produto de limpeza a ser adicionado.</param>
        public bool AdicionarProdutoLimpeza(Limpeza limpeza)
        {
            if (totalprodutolimpeza < MAX_limpeza)
            {
                limpezasArray[totalprodutolimpeza] = limpeza;
                totalprodutolimpeza++;
                return true;
            }
            else
            {
        
                return false; 
            }
        }

        /// <summary>
        /// Remove um produto de limpeza do array com base no código.
        /// </summary>
        /// <param name="codigo">O código do produto de limpeza a ser removido.</param>
        public bool RemoverProdutoLimpeza(int codigo)
        {
            for (int i = 0; i < totalprodutolimpeza; i++)
            {
                if (limpezasArray[i].Codigo == codigo)
                {
                    for (int j = i; j < totalprodutolimpeza - 1; j++)
                    {
                        limpezasArray[j] = limpezasArray[j + 1];
                    }
                    limpezasArray[totalprodutolimpeza - 1] = null;
                    totalprodutolimpeza--;
                    return true; 
                }
            }

            return false; 
        }

        /// <summary>
        /// Retorna o número total de produtos de limpeza no array.
        /// </summary>
        public int ContarProdutoLimpeza()
        {
            return totalprodutolimpeza;
        }

        #endregion
    }
}
