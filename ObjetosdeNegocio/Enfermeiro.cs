﻿/*
*	<copyright file="Enfermeiro" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 25/10/2023 17:31:32</date>
*	<description></description>
**/


using static System.Net.Mime.MediaTypeNames;
using System.Net;

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Representa a classe Enfermeiro, que é uma subclasse de Funcionario.
    /// </summary>
    [Serializable]
    public class Enfermeiro : Funcionario
    {
        #region Atributos

        int codigoenfermeiro;
        string condicao;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão para a classe Enfermeiro.
        /// </summary>
        public Enfermeiro()
        {
            codigoenfermeiro = 0;
            condicao = "";
        }

      
        /// <summary>
        /// Construtor por parametros
        /// </summary>
        /// <param name="codigoEnfermeiro"></param>
        /// <param name="condicao"></param>
        /// <param name="codigo"></param>
        /// <param name="dataentrada"></param>
        /// <param name="cargo"></param>
        /// <param name="contacto"></param>
        /// <param name="nome"></param>
        /// <param name="apelido"></param>
        /// <param name="idade"></param>
        /// <param name="NIF"></param>
        /// <param name="SNS"></param>
        public Enfermeiro(int codigoEnfermeiro, string condicao, int codigo, string dataentrada, string cargo, int contacto, string nome, string apelido, int idade, int NIF, int SNS)
           : base(codigo, dataentrada, cargo, contacto, nome, apelido, idade, NIF, SNS)
        {
            this.codigoenfermeiro = codigoEnfermeiro;
            this.condicao = condicao;
        }


        /// <summary>
        /// Obtem ou define o codigo de enfermeiro
        /// </summary>
        public int CodigoEnfermeiro
        {
            get { return codigoenfermeiro; }
            set { codigoenfermeiro = value; }
        }

        /// <summary>
        /// Obtém ou define a condição de enfermreiro.
        /// </summary>
        public string Condicao
        {
            get { return condicao; }
            set { condicao = value; }
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Operador de igualdade para comparar dois objetos Enfermeiro.
        /// </summary>
        public static bool operator ==(Enfermeiro e1, Enfermeiro e2)
        {
            if (  (e1.CodigoEnfermeiro == e2.CodigoEnfermeiro) && (e1.Sns == e2.Sns) && (e1.Nif == e2.Nif))
                return true;

            return false;
        }

        /// <summary>
        /// Operador de desigualdade para comparar dois objetos Enfermeiro.
        /// </summary>
        public static bool operator !=(Enfermeiro e1, Enfermeiro e2)
        {
            if (e1 == e2)
                return false;

            return true;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Sobrescreve o método ToString para fornecer uma representação de string do objeto Enfermeiro.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - SNS: {2} - NIF:{3} - Contacto{4}:", Nome, CodigoEnfermeiro.ToString(),Sns.ToString(),Nif.ToString(), Contacto.ToString());
        }

        /// <summary>
        /// Sobrescreve o método Equals para comparar objetos Enfermeiro.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Enfermeiro)
            {
                Enfermeiro e = (Enfermeiro)obj;
                if (this == e)
                {
                    return true;
                }
            }
            return false;
        }


     

        #endregion

    }

}
