using Funcionario;
using System.Diagnostics.Contracts;

namespace Funcionario
{
    class Medico : Funcionario
    {

        #region Atributos
        int codigoMedico;
        string especialidade;
        #endregion

        #region Metodos

        #region Construtores
        public Medico()
        {
            codigoMedico = 0;
            especialidade = "";
        }
        #endregion

        #region Propriedades
        public int CodigoMedico
        {
            get { return codigoMedico; }
            set { codigoMedico = value; }
        }

        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
        #endregion
    

#region Operadores

#endregion

#region Overrides

        #endregion

        #region Destruidores
        #endregion

        #endregion


    }
}
