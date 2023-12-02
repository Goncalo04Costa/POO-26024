/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Classe base que representa uma pessoa genérica.
    /// </summary>
    public class Pessoa
    {
        #region Atributos

        string nome;
        string apelido;
        int idade;
        int NIF;
        int SNS;
        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão sem parâmetros para a classe Pessoa.
        /// Inicializa os atributos com valores padrão.
        /// </summary>
        public Pessoa()
        {
            nome = "";
            apelido = "";
            idade = 0;
            NIF = 0;
            SNS = 0;
        }
        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome da pessoa.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o apelido da pessoa.
        /// </summary>
        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        /// <summary>
        /// Obtém ou define a idade da pessoa.
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        /// <summary>
        /// Obtém ou define o NIF (Número de Identificação Fiscal) da pessoa.
        /// </summary>
        public int Nif
        {
            get { return NIF; }
            set { NIF = value; }
        }

        /// <summary>
        /// Obtém ou define o número de Segurança Social (SNS) da pessoa.
        /// </summary>
        public int Sns
        {
            get { return SNS; }
            set { SNS = value; }
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Compara duas pessoas para igualdade com base em seus atributos.
        /// </summary>
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            if ((p1.nome == p2.nome) && (p1.apelido == p2.apelido) && (p1.idade == p2.idade) && (p1.NIF == p2.NIF) && (p1.SNS == p2.SNS))
                return true;
            return false;
        }

        /// <summary>
        /// Compara duas pessoas para desigualdade com base em seus atributos.
        /// </summary>
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Overrides

        /// <summary>
        /// Retorna uma representação em string da pessoa.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} - Idade: {2} - NIF: {3} - SNS: {4}", nome, apelido, idade.ToString(), NIF.ToString(), SNS.ToString());
        }

        /// <summary>
        /// Determina se a pessoa é igual a outro objeto.
        /// </summary>
   
        public override bool Equals(object obj)
        {
            if (obj is Pessoa)
            {
                Pessoa p = (Pessoa)obj;
                if (this == p)
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


        #endregion
    }
}
