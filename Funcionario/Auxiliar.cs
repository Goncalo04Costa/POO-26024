using PESSOA;
namespace FUNCIONARIO
{
    internal class Auxiliar : Funcionario
    {
        #region Atributos
        int codigoAuxiliar;
        string condicao;
        #endregion

        #region Metodos

        #region Construtores
        public Auxiliar()
        {
            codigoAuxiliar = 0;
            condicao = "";
        }
        #endregion

        #region Propriedades

        int Codigomedico
        {
            get { return codigoAuxiliar; }
            set { codigoAuxiliar = value; }
        }
        string Condicao
        {
            get { return condicao; }
            set { condicao = value; }
        }
        #endregion

        #region Operadores
        public static bool operator ==(Auxiliar a1, Auxiliar a2)
        {
            if ((a1.Nome == a2.Nome) && (a1.codigoAuxiliar == a2.codigoAuxiliar) && (a1.Contacto == a2.Contacto))
                return true;
            return false;
        }

        public static bool operator !=(Auxiliar a1, Auxiliar a2)
        {

            if (a1 == a2)
                return false;
            return true;

        }
        #endregion

        #region Overrides
        public override string ToString()
        {

            return String.Format("Nome: {0} - Codigo: {1} - Contacto{2}:", Nome, codigoAuxiliar.ToString(), Contacto.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is Auxiliar)
            {
                Auxiliar a = (Auxiliar)obj;
                if (this == a)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Destruidores
        #endregion

        #endregion
    }
}
