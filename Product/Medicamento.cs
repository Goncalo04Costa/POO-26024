/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */
namespace Product
{
    /// <summary>
    /// Classe que representa um Medicamento, derivado da classe base Produto.
    /// </summary>
    public class Medicamento : Produto
    {

        #region Atributos
        int codigomedicamento;
        string marca;
        #endregion

        #region Métodos

        #region Construtores
        /// <summary>
        /// Construtor padrão que inicializa um Medicamento com código e marca padrão.
        /// </summary>
        public Medicamento()
        {
            codigomedicamento = 0;
            marca = "";
        }

        /// <summary>
        /// Construtor que permite definir um Medicamento com código e marca específicos.
        /// </summary>
        /// <param name="codigomedicamento">O código do Medicamento.</param>
        /// <param name="fornecedor">A marca do Medicamento.</param>
        public Medicamento(int codigomedicamento, string marca)
        {
            this.marca = marca;
            this.codigomedicamento = codigomedicamento;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o código do Medicamento.
        /// </summary>
        public int CodigoMedicamento
        {
            get { return codigomedicamento; }
            set { codigomedicamento = value; }
           
        }

        /// <summary>
        /// Obtém ou define o fornecedor/marca do Medicamento.
        /// </summary>
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga do operador de igualdade para Medicamentos.
        /// Compara o código e a marca dos Medicamentos para determinar igualdade.
        /// </summary>
        public static bool operator ==(Medicamento m1, Medicamento m2)
        {
            if ((m1.CodigoMedicamento == m2.CodigoMedicamento) && (m1.Marca == m2.Marca))
                return true;
            return false;
        }

        /// <summary>
        /// Sobrecarga do operador de desigualdade para Medicamentos.
        /// Compara o código e a marca dos Medicamentos para determinar desigualdade.
        /// </summary>
        public static bool operator !=(Medicamento m1, Medicamento m2)
        {
            if (m1 == m2)
                return false;
            return true;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Retorna uma representação em string do objeto Medicamento.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - CodigoMedicamento: {2} - Fornecedor: {3} - Stock: {4}", Nome, Codigo.ToString(), codigomedicamento.ToString(), marca, Stock.ToString());
        }

        /// <summary>
        /// Determina se o objeto Medicamento é igual a outro objeto.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Medicamento)
            {
                Medicamento m = (Medicamento)obj;
                return this == m;
            }
            return false;
        }

        
         ///<summary>
        /// Sobrescrita do método GetHashCode para geração do código hash.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #endregion

    }
}
