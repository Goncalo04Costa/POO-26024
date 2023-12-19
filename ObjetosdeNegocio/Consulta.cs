/*
*	<copyright file="Consulta" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 27/11/2023 13:14:49</date>
*	<description></description>
**/

using Interfaces;
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
        /// <summary>
        /// Construtor padrao
        /// </summary>
        public Consulta()
        {
            consultaid = 0;
            data = DateTime.Now;
            SNSUTENTE = 0;
            codigomedico = 0;
            hospital = "";
            distancia = 0;
        }


        /// <summary>
        /// Construtor por parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataConsulta"></param>
        /// <param name="snsUtente"></param>
        /// <param name="codigoMedico"></param>
        /// <param name="nomeHospital"></param>
        /// <param name="distanciaConsulta"></param>
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

        /// <summary>
        /// Prorpriedade para id da consulta
        /// </summary>
        public int Consultaid
        {
            set { consultaid = value; }
            get { return consultaid; }
        }


        /// <summary>
        /// Propriedade para a data da consulta
        /// </summary>
        public DateTime Data
        {
            set { data = value; }
            get { return data; }
        }

        /// <summary>
        /// Propriedade para o SNS do utente
        /// </summary>
        public int SNSutente
        {
            set { SNSUTENTE = value; }
            get { return SNSUTENTE; }
        }

        /// <summary>
        /// Prorpietario do codigo de medico da consulta
        /// </summary>
        public int codmed
        {
            set { codigomedico = value; }
            get { return codigomedico; }
        }


        /// <summary>
        /// propriedade para o hospital onde a consulta vai ocorrer
        /// </summary>
        public string Hospital
        {
            set { hospital = value; }
            get { return hospital; }
        }

        /// <summary>
        /// Propriedade para a distancia na viagem ate ao hospital
        /// </summary>
        public int Distancia
        {
            set { distancia = value; }
            get { return distancia; }
        }
        #endregion

        #region Operadores
        /// <summary>
        ///  Compara dois objetos Consulta para igualdade.
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

        /// <summary>
        /// Compara dois objetos Consulta para desigualdade
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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



        /// <summary>
        /// Método para comparar Consultas com base na data.
        /// </summary>
        /// <param name="other">Outra Consulta a ser comparada.</param>
        /// <returns>Um valor inteiro que indica a relação entre as datas.</returns>
        public int CompareTo(Consulta other)
        {
            // Verifica se o objeto other é nulo
            if (other == null) return 1;

            // Comparação das datas
            return this.data.CompareTo(other.data);
        }



        #endregion

        #region Destruidores
        #endregion

        #endregion


    }
}