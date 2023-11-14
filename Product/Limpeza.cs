using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Contracts;
using System.Net;

namespace Product
{
    public class Limpeza: Produto
    {
        #region Atributos
        int referencia;
 
        string descricao;
        #endregion

        #region Metodos

        #region Construtores
        public Limpeza()
        {
            referencia = 0;
            descricao = "";
           
        }
        #endregion

        #region Propriedades
        public int Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

  

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        #endregion

        #region Operadores
        public static bool operator ==(Limpeza l1, Limpeza l2)
        {
            if ((l1.Descricao == l2.Descricao) && (l1.Referencia == l2.Referencia))
                return true;
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Limpeza l1, Limpeza l2)
        {

            if (l1 == l2)
                return false;
            return true;

        }
        #endregion

        #region Overrides
        /// <summary>
        /// Retorna uma representação em string do objeto de Limpeza
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - Referencia{2} - Descrição{3} - Stock{4}:", Nome, Codigo.ToString(), referencia.ToString(), descricao, Stock.ToString());
        }

        /// <summary>
        /// Determina se o objeto de  Limpeza é igual a outro objeto.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Limpeza)
            {
                Limpeza l = (Limpeza)obj;
                return this == l;
            }
            return false;
        }

        /// <summary>
        /// Retorna um código hash para o objeto Auxiliar.
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(Nome,Codigo, referencia, descricao, Stock);
        }
        #endregion

        #region Destruidores
        #endregion

        #endregion


    }
}
