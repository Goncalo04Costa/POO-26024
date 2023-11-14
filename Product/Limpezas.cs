namespace Product
{
    public class Limpezas
    {
        private Limpeza[] limpezasArray;
        private const int MAX_limpeza = 200;
        private int totalprodutolimpeza;

        /// <summary>
        /// Construtor padrão que inicializa um array de medicamentos e define o total de medicamentos como 0.
        /// </summary>
        public Limpezas()
        {
            limpezasArray = new Limpeza[MAX_limpeza];
            totalprodutolimpeza = 0;
        }

        /// <summary>
        /// Obtém o número máximo de medicamentos permitidos.
        /// </summary>
        public static int MaxProdutoLimpeza { get { return MAX_limpeza; } }

        /// <summary>
        /// Obtém uma cópia do array de medicamentos.
        /// </summary>
        public Limpeza[] LimpezasArray
        {
            get { return (Limpeza[])limpezasArray.Clone(); }
            set { }
        }

        /// <summary>
        /// Obtém o total atual de medicamentos no array.
        /// </summary>
        public int TotalprodutoLimpeza
        {
            get { return totalprodutolimpeza; }
        }

        #region Outros Métodos

        /// <summary>
        /// Adiciona um limpeza ao  array, desde que o limite máximo não tenha sido atingido.
        /// </summary>
        /// <param name="limpeza">O  limpeza a ser adicionado.</param>
        public void Newprodutolimpeza(Limpeza limpeza)
        {
            if (totalprodutolimpeza < MAX_limpeza)
            {
                limpezasArray[totalprodutolimpeza] = limpeza;
                totalprodutolimpeza++;
            }
            else
            {
                Console.WriteLine("O limite máximo de produtos de limpeza foi atingido. Não é possível adicionar.");
            }
        }


        /// <summary>
        /// Remove um produto com base no codigo.
        /// </summary>
        /// <param name="codigo">O codigo do produto a ser removido.</param>
        public void RemoverProdutoLimpeza(int codigo)
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
                    return;
                }
            }
        }

        /// <summary>
        /// Retorna o número total de produto de limpeza no array.
        /// </summary>
        public int ContarProdutoLimpeza()
        {
            return totalprodutolimpeza; 
        }

        #endregion
    }
}
