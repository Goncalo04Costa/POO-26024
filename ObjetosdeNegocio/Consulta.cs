using static System.Net.Mime.MediaTypeNames;

namespace ObjetosdeNegocio
{
    [Serializable]
    public class Consulta  : IComparable<Consulta>
    {
        #region Atributos
        int consultaid;
        DateTime data;
        int SNSUTENTE;
        int codigomedico;
        string hospital;
        int distancia;
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
            distancia = 0;
        }


        public Consulta(int id, DateTime dataConsulta, int snsUtente, int codigoMedico, string nomeHospital, int distanciaConsulta)
        {
            this.consultaid = id;
            this.data = dataConsulta;
            this.SNSUTENTE = snsUtente;
            this.codigomedico = codigoMedico;
           this.hospital = nomeHospital;
            this.distancia = distanciaConsulta;
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

        public int Distancia
        {
            set { distancia = value; }
            get { return distancia; }
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
            return String.Format("Numero de consulta: {0} - Data: {1} - Utente: {2} - Medico: {3} - Hospiral: {4} - Distancia: {5}", consultaid.ToString(), data.ToString(), SNSUTENTE.ToString(), codigomedico.ToString(), hospital, distancia.ToString());
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



        public int CompareTo(Consulta other)
        {
            if (other == null) return 1;
            return this.distancia.CompareTo(other.distancia);
        }


        #endregion

        #region Destruidores
        #endregion

        #endregion


    }
}