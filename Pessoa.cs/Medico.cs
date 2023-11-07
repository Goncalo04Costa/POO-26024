using FUNCIONARIO;
using PESSOA;
namespace FUNCIONARIO

{
    public class Medico : Funcionario
    {
        #region Atributos
        int codigoMedico;
        string especialidade;
        #endregion

        #region Construtores
        public Medico()
        {
            codigoMedico = 0;
            especialidade = "";
        }

        public Medico(int codigoMedico, string especialidade)

        {
            this.codigoMedico = codigoMedico;
            this.especialidade = especialidade;
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
        public static bool operator ==(Medico m1, Medico m2)
        {
            if ((m1.codigoMedico == m2.codigoMedico) && (m1.Nome == m2.Nome) && (m1.Apelido == m2.Apelido) && (m1.Idade == m2.Idade) && (m1.Nif == m2.Nif) && (m1.Sns == m2.Sns) && (m1.especialidade == m2.especialidade))
                return true;
            return false;
        }

        public static bool operator !=(Medico m1, Medico m2)
        {

            if (m1 == m2)
                return false;
            return true;

        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} - Especialidade: {2} - Codigo Medico: {3}}", Nome, Apelido, especialidade, codigoMedico.ToString());
        }


        public override bool Equals(object obj)
        {
            if (obj is Medico)
            {
                Medico m = (Medico)obj;
                if (this == m)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Destruidores
        #endregion



    }
}
