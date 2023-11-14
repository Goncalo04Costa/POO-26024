/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace Equipment
{
    public class Equipamento : IEquipamento
    {
        #region Atributos
        int codigo;
        string nome;
        string descricao;
        int carga;
        int estado;
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
           estado = 0; 
        }

        public Equipamento( int codigo, string nome, string descricao, int carga, int estado)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.descricao = descricao;
            this.carga = carga;
            this.estado = estado;
        }
        #endregion

        #region Propriedades
       
        public int Codigo
        {
            
         get { return codigo; }
         set { codigo = value; }

        }
        public string Nome
        {
            get{ return nome;}
           set { nome = value; }
        }
        
        public  string Descricao 
        {   get { return descricao; }
            set { descricao = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
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
            if ((e1.Codigo == e2.Codigo ) && (e1.Nome == e2.Nome) && (e1.Descricao == e2.Descricao) && (e1.Carga == e2.Carga) && (e1.Estado == e2.Estado))
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
        }
        #endregion

        #region Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return String.Format( "Codigo: {0} - Nome: {1} - Descrição: {2} - Carga: {3} - Estado:{4}: ",codigo.ToString(), nome, descricao, carga.ToString(), estado.ToString());
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