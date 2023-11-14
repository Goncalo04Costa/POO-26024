namespace Equipment
{
    public class Equipamento
    {
        #region Atributos
        int codigo;
        string nome;
        string descricao;
        int carga;
        #endregion

        #region Metodos

        #region Construtores
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Equipamento()
        {
            codigo = 0;
            nome = "";
            descricao = "";
            carga = 0;
        }

        public Equipamento( int codigo, string nome, string descricao, int carga)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.descricao = descricao;
            this.carga = carga;
        }
        #endregion

        #region Propriedades
       
        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
          
        }
        public string Nome
        {
            set { nome = value;}
            get{ return nome;}
        }
        
        public  string Descricao 
        {   get { return descricao; }
            set { descricao = value; }
        }

        public int Carga
        {
            get { return carga; }
            set { carga = value; }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Equipamento e1, Equipamento e2)
        {
            if ((e1.Codigo == e2.Codigo ) && (e1.Nome == e2.Nome) && (e1.Descricao == e2.Descricao) && (e1.Carga == e2.Carga))
                return true;
            return false;
        }

        //><=
        //+
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator !=(Equipamento e1, Equipamento e2)
        {
            
            if (e1 == e2)
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

            return String.Format( "Codigo: {0} - Nome: {0} - Descrição: {1} - Carga: {2}: ",codigo.ToString(), nome, descricao, carga.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Equipamento)
            {
                Equipamento e = (Equipamento)obj;
                if (this == e)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Destruidores
        #endregion

        #endregion



    }
}