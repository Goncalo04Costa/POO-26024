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
    /// A classe Funcionario representa um funcionário que herda da classe Pessoa.
    /// </summary>
    [Serializable]
    public class Funcionario : Pessoa
    {
        #region Atributos

        int codigo;
        string dataentrada;
        string cargo;
        int contacto;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Funcionario.
        /// </summary>
        public Funcionario()
        {
            codigo = 0;
            dataentrada = "";
            cargo = "";
            contacto = 0;
        }

        /// <summary>
        /// Construtor da classe Funcionario com parâmetros.
        /// </summary>
        /// <param name="codigo">O código do funcionário.</param>
        /// <param name="dataentrada">A data de entrada do funcionário.</param>
        /// <param name="cargo">O cargo do funcionário.</param>
        public Funcionario(int codigo, string dataentrada, string cargo, int contacto)
        {
            this.codigo = codigo;
            this.dataentrada = dataentrada;
            this.cargo = cargo;
           this.contacto = contacto;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o código do funcionário.
        /// </summary>
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Obtém ou define a data de entrada do funcionário.
        /// </summary>
        public string DataEntrada
        {
            get { return dataentrada; }
            set { dataentrada = value; }
        }

        /// <summary>
        /// Obtém ou define o cargo do funcionário.
        /// </summary>
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        /// <summary>
        /// Obtém ou define a condição do funcionário.
        /// </summary>
        public int Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar dois funcionários.
        /// </summary>
        public static bool operator ==(Funcionario f1, Funcionario f2)
        {
            if ((f1.Nome == f2.Nome) && (f1.Apelido == f2.Apelido) && (f1.Contacto == f2.Contacto) && (f1.Idade == f2.Idade) && (f1.Nif == f2.Nif) && (f1.Sns == f2.Sns) && (f1.codigo == f2.codigo))
                return true;
            return false;
        }

        /// <summary>
        /// Sobrecarga do operador de desigualdade para comparar dois funcionários.
        /// </summary>
        public static bool operator !=(Funcionario f1, Funcionario f2)
        {
            if (f1 == f2)
                return false;
            return true;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Sobrescreve o método ToString para fornecer uma representação de string do funcionário.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} - Idade: {2} - Contacto: {3} - NIF: {4} - SNS: {5} - Código: {6} - Data de Entrada: {7} - Cargo: {8}", Nome, Apelido, Idade.ToString(), Contacto.ToString(), Nif.ToString(), Sns.ToString(), codigo.ToString(), dataentrada, cargo);
        }

        /// <summary>
        /// Sobrescreve o método Equals para comparar se dois funcionários são iguais.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Funcionario)
            {
                Funcionario f = (Funcionario)obj;
                if (this == f)
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
