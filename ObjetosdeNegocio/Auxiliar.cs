/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */
namespace ObjetosdeNegocio
{
    /// <summary>
    /// Representa um Auxiliar que é um tipo de Funcionário.
    /// </summary>
    [Serializable]
    public class Auxiliar : Funcionario , IComparable<Auxiliar>
    {
        #region Atributos

       int codigoAuxiliar;
       string condicao;

        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Construtor padrão sem parâmetros para a classe Auxiliar.
        /// Inicializa o código do Auxiliar como 0 e a condição como uma string vazia.
        /// </summary>
        public Auxiliar()
        {
            codigoAuxiliar = 0;
            condicao = "";
        }

        /// <summary>
        /// Construtor que permite definir o código e a condição do Auxiliar.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do Auxiliar.</param>
        /// <param name="condicao">A condição do Auxiliar.</param>
        public Auxiliar(int codigo, string dataentrada, string cargo, int contacto, int codigoAuxiliar, string condicao, string nome, string apelido, int idade, int NIF, int SNS)
    : base(codigo, dataentrada, cargo, contacto, nome, apelido, idade, NIF, SNS)
        {
            this.codigoAuxiliar = codigoAuxiliar;
            this.condicao = condicao;
        }


        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o código do Auxiliar.
        /// </summary>
        public int CodigoAuxiliar
        {
            get { return codigoAuxiliar; }
            set { codigoAuxiliar = value; }
        }

        /// <summary>
        /// Obtém ou define a condição do Auxiliar.
        /// </summary>
        public string Condicao
        {
            get { return condicao; }
            set { condicao = value; }
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Compara dois objetos Auxiliar para igualdade.
        /// </summary>
        public static bool operator ==(Auxiliar a1, Auxiliar a2)
        {
            if ( (a1.Codigo == a2.Codigo) && (a1.Cargo == a2.Cargo))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compara dois objetos Auxiliar para desigualdade.
        /// </summary>
        public static bool operator !=(Auxiliar a1, Auxiliar a2)
        {
            return !(a1 == a2);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Retorna uma representação em string do objeto Auxiliar.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - Contacto{2}:", Nome, codigoAuxiliar.ToString(), Contacto.ToString());
        }

        /// <summary>
        /// Determina se o objeto Auxiliar é igual a outro objeto.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Auxiliar)
            {
                Auxiliar a = (Auxiliar)obj;
                return this == a;
            }
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Auxiliar other)
        {
            if (other == null) return 1;
            return this.DataEntrada.CompareTo(other.DataEntrada);
        }


        #endregion

        #endregion
    }
}
