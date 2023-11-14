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
                //if (value<0)
                codigomedicamento = value;
            }
            get
            {
                //if(pode_saber_a_minha_idade)
                return codigomedicamento;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fornecedor
        {
            get { return fornecedor.ToUpper(); }
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

        //><=
        //+
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Medicamento m1, Medicamento m2)
        {
            //if (!((p1.Nome == p2.Nome) && (p1.idade == p2.idade)))
            if (m1 == m2)
                return false;
            return true;
            //ou
            //return (!(p1 == p2));
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            //return base.ToString();

            //return "Nome: " + nome + " Idade: " + idade;
            return String.Format("Forncedor: {0} - Codigo Medicamento: {1}", fornecedor, codigomedicamento.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Medicamento)
            {
                Medicamento m = (Medicamento)obj;
                if (this == m)
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
