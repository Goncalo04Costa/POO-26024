/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace Product
{
    public class Produto
    {
        #region ESTADO 

         string nome;
         int codigo;
         int stock;

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Produto()
        {
            codigo = 0;
            nome = "";
            stock = 0;
        }

        public Produto(int codigo, string nome, int stock)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.stock = stock;
        }

      
        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// 
        /// </summary>
        public int Codigo
        {
            set
            {
                codigo = value;
            }
            get
            {
                return codigo;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        #endregion

        #region Operadores

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Produto p1, Produto p2)
        {
            if ((p1.Nome == p2.Nome) && (p1.Codigo== p2.Codigo) && (p1.Stock == p2.Stock))
                return true;
            return false;
        }

        //><=
        //+
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Produto p1, Produto p2)
        {
            //if (!((p1.Nome == p2.Nome) && (p1.idade == p2.idade)))
            if (p1 == p2)
                return false;
            return true;
            //ou
            //return (!(p1 == p2));
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
          
            return String.Format("Nome: {0} - Codigo: {1} - Stoc: {2}: ", nome, codigo.ToString(), stock.ToString());
        }
         
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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