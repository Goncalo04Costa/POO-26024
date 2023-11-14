

namespace Persons
{
    public class Fisioterapeuta : Funcionario
    {
        #region Atributos

        public int codigofisioterapeuta;
        public string condicao;

        #endregion

        #region Construtores

        
        public Fisioterapeuta()
        {
            codigofisioterapeuta = 0;
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
        public Fisioterapeuta(int codigoFisioterapeuta, string condicao, string nome, string apelido, int idade, int nif, int sns, int contacto, string Nome, string Apelido, int Idade, int NIF, int SNS, int Contacto)
        {
            this.codigofisioterapeuta = codigoFisioterapeuta;
            this.condicao = condicao;
        }



        public int CodigoFisioterapeuta
        {
            get { return codigofisioterapeuta; }
            set { codigofisioterapeuta = value; }
        }

        /// <summary>
        /// Obtém ou define a especialidade do médico.
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
        public static bool operator ==(Fisioterapeuta f1, Fisioterapeuta f2)
        {
            if ((f1.Nome == f2.Nome) && (f1.codigofisioterapeuta == f2.codigofisioterapeuta) && (f1.Sns == f2.Sns) && (f1.Nif == f2.Nif))
                return true;

            return false;
        }

        /// <summary>
        /// Operador de desigualdade para comparar dois objetos Enfermeiro.
        /// </summary>
        public static bool operator !=(Fisioterapeuta f1, Fisioterapeuta f2)
        {
            if (f1 == f2)
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
            return String.Format("Nome: {0} - Codigo: {1} - Contacto{2}:", Nome, codigofisioterapeuta.ToString(), Contacto.ToString());
        }

        /// <summary>
        /// Sobrescreve o método Equals para comparar objetos Enfermeiro.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Fisioterapeuta)
            {
                Fisioterapeuta f = (Fisioterapeuta)obj;
                if (this == f)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrescreve o método GetHashCode.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }

}
