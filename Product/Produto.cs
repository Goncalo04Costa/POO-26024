namespace Product
{
    public class Produto
    {
        #region ESTADO 

         string nome;
         int codigo;    

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
        }

        public Produto(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        //public Pessoa(int id, string no)
        //{
        //    idade = id;
        //    nome = no;
        //}
        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// 
        /// </summary>
        public int Codigo
        {
            set
            {
                //if (value<0)
                codigo = value;
            }
            get
            {
                //if(pode_saber_a_minha_idade)
                return codigo;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
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
            if ((p1.Nome == p2.Nome) && (p1.Codigo== p2.Codigo))
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
            //return base.ToString();

            //return "Nome: " + nome + " Idade: " + idade;
            return String.Format("Nome: {0} - Codigo: {1}", nome, codigo.ToString());
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