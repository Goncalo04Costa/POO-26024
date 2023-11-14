using static System.Net.Mime.MediaTypeNames;

namespace Product
{
    internal class Medicamento : Produto
    {

        #region Atributos
        int codigomedicamento;
        string fornecedor;
        #endregion

        #region Metodos

        #region Construtores
        public Medicamento()
        {
            codigomedicamento = 0;
            fornecedor = "";
        }

        public Medicamento(int codigomedicamento, string fornecedor)
        {
            this.fornecedor = fornecedor;
            this.codigomedicamento = codigomedicamento;
        }
        #endregion

        #region Propriedades
        public int CodigoMedicamento
        {
            set
            {
                codigomedicamento = value;
            }
            get
            {
           
                return codigomedicamento;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        #endregion

        #region Operadores
        public static bool operator ==(Medicamento m1, Medicamento m2)
        {
            if ((m1.CodigoMedicamento == m2.CodigoMedicamento) && (m1.Fornecedor == m2.Fornecedor))
                return true;
            return false;
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Medicamento m1, Medicamento m2)
        {
         
            if (m1 == m2)
                return false;
            return true;
         
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - CodigoMedicamento{2} - Fornecedor{3} - Stock{4}:", Nome, Codigo.ToString(), codigomedicamento.ToString(),fornecedor, Stock.ToString());
        }

        /// <summary>
        /// Determina se o objeto Medicamento é igual a outro objeto.
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
        /// Retorna um código hash para o objeto Medicamento.
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Codigo, codigomedicamento, fornecedor, Stock);
        }

        #endregion

        #region Destruidores
        #endregion

        #endregion

    }
}
