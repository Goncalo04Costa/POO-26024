/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */
namespace Persons
{
    /// <summary>
    /// Representa um Auxiliar que é um tipo de Funcionário.
    /// </summary>
    public class Auxiliar : Funcionario
    {
        #region Atributos

        /// <summary>
        /// Obtém ou define o código do Auxiliar.
        /// </summary>
        public int codigoAuxiliar;
        /// <summary>
        /// Obtém ou define a condição do Auxiliar.
        /// </summary>
        public string condicao;

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
        public Auxiliar(int codigoAuxiliar, string condicao)
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
            if ((a1.Nome == a2.Nome) &&
                (a1.Apelido == a2.Apelido) &&
                (a1.Contacto == a2.Contacto) &&
                (a1.Idade == a2.Idade) &&
                (a1.Nif == a2.Nif) &&
                (a1.Sns == a2.Sns) &&
                (a1.codigoAuxiliar == a2.codigoAuxiliar) &&
                (a1.condicao == a2.condicao))
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
        /// Retorna um código hash para o objeto Auxiliar.
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Apelido, Contacto, Idade, Nif, Sns, codigoAuxiliar, condicao);
        }

        #endregion

        #endregion
    }
}
