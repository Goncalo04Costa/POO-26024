/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Classe base para representar um Produto .
    /// </summary>
    public class Produto
    {
        #region ATRIBUTOS

        string nome;
        int codigo;
        int fornecedor;
        int stock;

        #endregion

        #region METODOS

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão.
        /// </summary>
        public Produto()
        {
            codigo = 0;
            nome = "";
            fornecedor = 0;
            stock = 0;
        }

        /// <summary>
        /// Construtor que recebe código, nome e fornecedor do produto.
        /// </summary>
        public Produto(int codigo, string nome, int fornecedor, int stock)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.fornecedor = fornecedor;
            this.stock = stock;
        }


        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Obtém ou define o código do produto.
        /// </summary>
        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        /// <summary>
        /// Obtém ou define o nome do produto.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o fornecedor do produto.
        /// </summary>
        public int Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }


        /// <summary>
        /// obtem ou define o stock do produto
        /// </summary>
        public int Stock
        {
            set {  stock = value; }
            get { return stock; }
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Verifica se dois objetos do tipo Produto são iguais com base no nome, código e fornecedor.
        /// </summary>
        /// <param name="p1">Primeiro Produto a ser comparado.</param>
        /// <param name="p2">Segundo Produto a ser comparado.</param>
        /// <returns>True se os produtos forem iguais, False caso contrário.</returns>
        public static bool operator ==(Produto p1, Produto p2)
        {
            if ((p1.Nome == p2.Nome) && (p1.Codigo == p2.Codigo) && (p1.fornecedor == p2.fornecedor) && (p1.stock == p2.stock))
                return true;
            return false;
        }

        /// <summary>
        /// Verifica se dois objetos do tipo Produto são diferentes com base no nome, código e fornecedor.
        /// </summary>
        /// <param name="p1">Primeiro Produto a ser comparado.</param>
        /// <param name="p2">Segundo Produto a ser comparado.</param>
        /// <returns>True se os produtos forem diferentes, False caso contrário.</returns>
        public static bool operator !=(Produto p1, Produto p2)
        {
            if (p1 == p2)
                return false;
            return true;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Retorna uma representação em string do objeto Produto.
        /// </summary>
        /// <returns>Uma string contendo informações sobre o Produto.</returns>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - Forncedor: {2} - Stock: {3} .", nome, codigo.ToString(), fornecedor.ToString(), stock.ToString());
        }

        /// <summary>
        /// Determina se o objeto Produto é igual a outro objeto.
        /// </summary>
        /// <param name="obj">O objeto a ser comparado.</param>
        /// <returns>True se os objetos forem iguais, False caso contrário.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Produto)
            {
                Produto p = (Produto)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #endregion
    }
}
