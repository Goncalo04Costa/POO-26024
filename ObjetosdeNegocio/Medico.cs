/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

using static System.Net.Mime.MediaTypeNames;
using System.Net;

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Representa a classe Medico que herda de Funcionario .
    /// </summary>
    [Serializable]
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
        public Medico(int codigoMedico, string especialidade, int codigo, string dataentrada, string cargo, int contacto, string nome, string apelido, int idade, int NIF, int SNS)
                 : base(codigo, dataentrada, cargo, contacto, nome, apelido, idade, NIF, SNS)
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
            if ((m1.Nome == m2.Nome) && (m1.CodigoMedico == m2.CodigoMedico) && (m1.Sns == m2.Sns) && (m1.Nif == m2.Nif) && (m1.Especialidade == m2.Especialidade))
                return true;

            return false;
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
            return String.Format("Nome: {0} {1} - Codigo: {2} - Especialidade: {3} - Contacto: {4}", Nome,Apelido,  codigoMedico.ToString(),Especialidade,  Contacto.ToString());
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
        /// Obtém um código hash para a pessoa.
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
