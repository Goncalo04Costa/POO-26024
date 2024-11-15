﻿/*
*	<copyright file="Diretor" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 25/10/2023 17:10:23</date>
*	<description></description>
**/

using System.Net;

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Representa um Diretor que é um tipo de Funcionário.
    /// </summary>
    [Serializable]
    public class Diretor : Funcionario
    {
        #region Atributos
        int codigochefe;
        int Gabinete;
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor padrão sem parâmetros para a classe Diretor.
        /// Inicializa o código do chefe como 0 e o número do gabinete como 0.
        /// </summary>
        public Diretor()
        {
            codigochefe = 0;
            Gabinete = 0;
        }

        /// <summary>
        /// Construtor que permite definir o número do gabinete e o código do chefe do Diretor.
        /// </summary>
        /// <param name="gab">O número do gabinete.</param>
        /// <param name="codf">O código do chefe.</param>
        /// <param name="nome">O nome do Diretor.</param>
        /// <param name="apelido">O apelido do Diretor.</param>
        /// <param name="idade">A idade do Diretor.</param>
        /// <param name="nif">O NIF do Diretor.</param>
        /// <param name="sns">O SNS do Diretor.</param>
        /// <param name="contacto">O contacto do Diretor.</param>
        public Diretor(int gab, int codf, int codigo, string dataentrada, string cargo, int contacto, string nome, string apelido, int idade, int NIF, int SNS)
             : base(codigo, dataentrada, cargo, contacto, nome, apelido, idade, NIF, SNS)
        {
            this.Gabinete = gab;
            this.codigochefe = codf;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o número do gabinete do Diretor.
        /// </summary>
        public int gabinete
        {
            get { return Gabinete; }
            set { Gabinete = value; }
        }

        /// <summary>
        /// Obtém ou define o código do chefe do Diretor.
        /// </summary>
        public int CodigoChefe
        {
            get { return codigochefe; }
            set { codigochefe = value; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Retorna uma representação em string do objeto Diretor.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} - Gabinete: {2} - Codigo: {3}", Nome, Apelido, Gabinete.ToString(), codigochefe.ToString());
        }

        /// <summary>
        /// Determina se o objeto Diretor é igual a outro objeto.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Diretor)
            {
                Diretor d = (Diretor)obj;
                return this == d;
            }
            return false;
        }

     

        #endregion
    }
}
