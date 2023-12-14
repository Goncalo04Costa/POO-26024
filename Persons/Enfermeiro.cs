/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace Persons
{
    /// <summary>
    /// Representa a classe Enfermeiro, que é uma subclasse de Funcionario.
    /// </summary>
    [Serializable]
    public class Enfermeiro : Funcionario
    {
        #region Atributos

        int codigoenfermeiro;
        string condicao;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão para a classe Enfermeiro.
        /// Inicializa CodigoEnfermeiro para 0 e Condicao para uma string vazia.
        /// </summary>
        public Enfermeiro()
        {
            codigoenfermeiro = 0;
            condicao = "";
        }

        /// <summary>
        /// Construtor parametrizado para a classe Enfermeiro.
        /// Inicializa CodigoEnfermeiro e Condicao com os valores fornecidos.
        /// </summary>
        /// <param name="codigoEnfermeiro">O código único atribuído ao Enfermeiro.</param>
        /// <param name="condicao">A condição/estado do Enfermeiro.</param>
        /// <param name="nome">Nome do Enfermeiro.</param>
        /// <param name="apelido">Apelido do Enfermeiro.</param>
        /// <param name="idade">Idade do Enfermeiro.</param>
        /// <param name="nif">NIF (Número de Identificação Fiscal) do Enfermeiro.</param>
        /// <param name="sns">Número do SNS (Serviço Nacional de Saúde) do Enfermeiro.</param>
        /// <param name="contacto">Número de contato do Enfermeiro.</param>
        public Enfermeiro(int codigoEnfermeiro, string condicao, string nome, string apelido, int idade, int nif, int sns, int contacto, string Nome, string Apelido,int Idade, int NIF, int SNS,int Contacto)
        {
            this.codigoenfermeiro = codigoEnfermeiro;
            this.condicao = condicao;
        }


        public int CodigoEnfermeiro
        {
            get { return codigoenfermeiro; }
            set { codigoenfermeiro = value; }
        }

        /// <summary>
        /// Obtém ou define a condição do Médico.
        /// </summary>
        public string Condicao
        {
            get { return condicao; }
            set { condicao = value; }
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Operador de igualdade para comparar dois objetos Enfermeiro.
        /// </summary>
        public static bool operator ==(Enfermeiro e1, Enfermeiro e2)
        {
            if ((e1.Nome == e2.Nome) && (e1.CodigoEnfermeiro == e2.CodigoEnfermeiro) && (e1.Sns == e2.Sns) && (e1.Nif == e2.Nif))
                return true;

            return false;
        }

        /// <summary>
        /// Operador de desigualdade para comparar dois objetos Enfermeiro.
        /// </summary>
        public static bool operator !=(Enfermeiro e1, Enfermeiro e2)
        {
            if (e1 == e2)
                return false;

            return true;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Sobrescreve o método ToString para fornecer uma representação de string do objeto Enfermeiro.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - SNS: {2} - NIF:{3} - Contacto{4}:", Nome, CodigoEnfermeiro.ToString(),Sns.ToString(),Nif.ToString(), Contacto.ToString());
        }

        /// <summary>
        /// Sobrescreve o método Equals para comparar objetos Enfermeiro.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Enfermeiro)
            {
                Enfermeiro e = (Enfermeiro)obj;
                if (this == e)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Obtém um código hash para a pessoa.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }

}
