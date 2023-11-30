using static System.Net.Mime.MediaTypeNames;

namespace Consultas
{
    [Serializable]
    public class Consulta
    {
        #region Atributos
        int consultaid;
        DateTime data;
        int SNSUTENTE;
        int codigomedico;
        string hospital;
        #endregion

        #region Metodos

        #region Construtores
        public Consulta()
        {
            consultaid = 0;
            data = DateTime.Now;
            SNSUTENTE = 0;
            codigomedico = 0;
            hospital = "";
        }
        #endregion

        #region Propriedades
        public int Consultaid
        {
            set { consultaid = value; }
            get { return consultaid; }
        }

        public DateTime Data
        {
            set { data = value; }
            get { return data; }
        }


        public int SNSutente
        {
            set { SNSUTENTE = value; }
            get { return SNSUTENTE; }
        }


        public int codmed
        {
            set { codigomedico = value; }
            get { return codigomedico; }
        }

        public string Hospital
        {
            set { hospital = value; }
            get { return hospital; }
        }

        #endregion

        #region Operadores
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==( Consulta a, Consulta b )
        {
            if ((a.consultaid ==  b.consultaid) && (a.hospital == b.hospital) && (a.codigomedico == b.codigomedico) && (a.SNSUTENTE == b.SNSUTENTE)) 
            {
            return true;}
            return false;
        }

        public static bool  operator !=( Consulta a, Consulta b )
        {  
            return !(a == b); 
        }
        #endregion

        #region Overrides


        /// <summary>
        /// Sobrescrita do método ToString para representação em string.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Numero de consulta: {0} - Data: {1} - Utente: {2} - Medico: {3} - Hospiral: {4}", consultaid.ToString(), data.ToString(), SNSUTENTE.ToString(), codigomedico.ToString(), hospital);
        }

        /// <summary>
        /// Sobrescrita do método Equals para comparação de igualdade.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Consulta)
            {
                Consulta c = (Consulta)obj;
                return this == c;
            }
            return false;
        }

        /// <summary>
        /// Sobrescrita do método GetHashCode para geração do código hash.
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