/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */
namespace Product
{
    public class Produtos
    {
        private Produto[] produtossArray;
        private const int MAX_produtos = 400;
        private int totalprodutos;

        /// <summary>
        /// Construtor padrão que inicializa um array de produtos e define o total de produtos como 0.
        /// </summary>
        public Produtos()
        {
            produtossArray = new Produto[MAX_produtos];
            totalprodutos = 0;
        }

        /// <summary>
        /// Obtém o número máximo de produtos permitidos.
        /// </summary>
        public static int MaxProdutos { get { return MAX_produtos; } }

        /// <summary>
        /// Obtém uma cópia do array de produtos.
        /// </summary>
        public Produto[] ProdutosArray
        {
            get { return (Produto[])ProdutosArray.Clone(); }
            set { }
        }

        /// <summary>
        /// Obtém o total atual de produtos no array.
        /// </summary>
        public int TotaldeProdutos
        {
            get { return totalprodutos; }
        }

        #region Outros Métodos

        public bool AdicionarProduto(Produto produto)
        {
            if (totalprodutos < MAX_produtos)
            {
                produtossArray[totalprodutos] = produto;
                totalprodutos++;
                return true; // Indica que o produto foi adicionado com sucesso
            }
            else
            {
                return false; // Indica que não foi possível adicionar o produto devido ao limite atingido
            }
        }

        public bool RemoverProduto(int codigo)
        {
            for (int i = 0; i < totalprodutos; i++)
            {
                if (produtossArray[i].Codigo == codigo)
                {
                    for (int j = i; j < totalprodutos - 1; j++)
                    {
                        produtossArray[j] = produtossArray[j + 1];
                    }
                    produtossArray[totalprodutos - 1] = null;
                    totalprodutos--;
                    return true; // Indica que o produto foi removido com sucesso
                }
            }

            return false; // Indica que o produto não foi encontrado para remoção
        }

        /// <summary>
        /// Retorna o número total de medicamentos no array.
        /// </summary>
        public int ContaProdutos()
        {
            return totalprodutos; 
        }

        #endregion
    }
}