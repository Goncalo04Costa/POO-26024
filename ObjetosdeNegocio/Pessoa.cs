/*
*	<copyright file="Pessoa" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 29/10/2023 11:32:53</date>
*	<description></description>
**/


namespace ObjetosdeNegocio
{
    /// <summary>
    /// Classe base que representa uma pessoa genérica.
    /// </summary>

    [Serializable]
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
        /// Construtor padrão 
        
        /// </summary>
        public Pessoa()
        {
            nome = "";
            apelido = "";
            idade = 0;
            NIF = 0;
            SNS = 0;
        }

        /// <summary>
        /// Construtor por parametros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="apelido"></param>
        /// <param name="idade"></param>
        /// <param name="nIF"></param>
        /// <param name="sNS"></param>
        public Pessoa(string nome, string apelido, int idade, int nIF, int sNS)
        {
            this.nome = nome;
            this.apelido = apelido;
            this.idade = idade;
            NIF = nIF;
            SNS = sNS;
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
         



        #endregion


        #endregion
    }
}
