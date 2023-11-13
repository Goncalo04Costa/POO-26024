/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace Person
{
    /// <summary>
    /// Representa a classe Medico (Médico) que herda de Funcionario (Funcionário).
    /// </summary>
    public class Medico : Funcionario
    {
        #region Atributos
        int codigoMedico;
        string especialidade;
        #endregion

        #region Métodos
        #region Construtores
        /// <summary>
        /// Construtor padrão para a classe Medico.
        /// </summary>
        public Medico()
        {
            codigoMedico = 0;
            especialidade = "";
        }

        /// <summary>
        /// Construtor parametrizado para a classe Medico.
        /// </summary>
        /// <param name="codigoMedico">O código do médico.</param>
        /// <param name="especialidade">A especialidade do médico.</param>
        /// <param name="nome">Nome do funcionário.</param>
        /// <param name="apelido">Apelido do funcionário.</param>
        /// <param name="idade">Idade do funcionário.</param>
        /// <param name="nif">NIF do funcionário.</param>
        /// <param name="sns">Número do SNS do funcionário.</param>
        /// <param name="contacto">Número de contacto do funcionário.</param>
        /// <param name="Nome">Nome do médico.</param>
        /// <param name="Apelido">Apelido do médico.</param>
        /// <param name="Idade">Idade do médico.</param>
        /// <param name="NIF">NIF do médico.</param>
        /// <param name="SNS">Número do SNS do médico.</param>
        /// <param name="Contacto">Número de contacto do médico.</param>
        public Medico(int codigoMedico, string especialidade, string nome, string apelido, int idade, int nif, int sns, int contacto, string Nome, string Apelido, int Idade, int NIF, int SNS, int Contacto)
        {
            this.codigoMedico = codigoMedico;
            this.especialidade = especialidade;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o código do médico.
        /// </summary>
        public int CodigoMedico
        {
            get { return codigoMedico; }
            set { codigoMedico = value; }
        }

        /// <summary>
        /// Obtém ou define a especialidade do médico.
        /// </summary>
        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Verifica se dois objetos Medico são iguais.
        /// </summary>
        public static bool operator ==(Medico m1, Medico m2)
        {
            if (object.ReferenceEquals(m1, m2))
                return true;

            if (m1 is null || m2 is null)
                return false;

            return m1.codigoMedico == m2.codigoMedico &&
                   m1.Nome == m2.Nome &&
                   m1.Apelido == m2.Apelido &&
                   m1.Idade == m2.Idade &&
                   m1.Nif == m2.Nif &&
                   m1.Sns == m2.Sns &&
                   m1.especialidade == m2.especialidade;
        }

        /// <summary>
        /// Verifica se dois objetos Medico são diferentes.
        /// </summary>
        public static bool operator !=(Medico m1, Medico m2)
        {
            return !(m1 == m2);
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Retorna uma representação em string do objeto Medico.
        /// </summary>
        public override string ToString()
        {
            return $"Nome: {Nome} {Apelido} - Especialidade: {especialidade} - Código Médico: {codigoMedico}";
        }

        /// <summary>
        /// Compara se dois objetos Medico são iguais.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Medico m)
            {
                return this == m;
            }
            return false;
        }

        /// <summary>
        /// Retorna o código de hash do objeto Medico.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Destruidores
        #endregion
        #endregion
    }
}
