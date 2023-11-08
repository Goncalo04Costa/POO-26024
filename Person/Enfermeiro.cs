

namespace Person
{

    public class Enfermeiro : Funcionario
    {
        #region Atributos
       public int codigoEnfermeiro;
       public string condicao;
        #endregion

        #region Metodos

        #region Construtores
        public Enfermeiro()
        {
            codigoEnfermeiro = 0;
            condicao = "";
        }

        public Enfermeiro(int codigoEnfermeiro, string condicao)

        {
            this.codigoEnfermeiro = codigoEnfermeiro;
            this.condicao = condicao;
        }
        #endregion

        #region Propriedades

        int Codigoenfermeiro
        {
            get { return codigoEnfermeiro; }
            set { codigoEnfermeiro = value; }
        }
        string Condicao
        {
            get { return condicao; }
            set { condicao = value; }
        }
        #endregion

        #region Operadores
        public static bool operator ==(Enfermeiro e1, Enfermeiro e2)
        {
            if ((e1.Nome == e2.Nome) && (e1.codigoEnfermeiro == e2.codigoEnfermeiro) && (e1.Sns == e2.Sns) && (e1.Nif == e2.Nif))
                return true;
            return false;
        }

        public static bool operator !=(Enfermeiro e1, Enfermeiro e2)
        {

            if (e1 == e2)
                return false;
            return true;

        }
        #endregion

        #region Overrides
        public override string ToString()
        {

            return String.Format("Nome: {0} - Codigo: {1} - Contacto{2}:", Nome, codigoEnfermeiro.ToString(), Contacto.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is Enfermeiro)
            {
                Enfermeiro f = (Enfermeiro)obj;
                if (this == f)
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

        #endregion
    }

}