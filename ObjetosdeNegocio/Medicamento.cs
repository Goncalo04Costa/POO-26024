﻿/*
*	<copyright file="Medicamento" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 29/10/2023 11:10:57</date>
*	<description></description>
**/

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Classe que representa um Medicamento, derivado da classe base Produto.
    /// </summary>
    public class Medicamento : Produto
    {

        #region Atributos
        int codigomedicamento;
        string marca;
        #endregion

        #region Métodos

        #region Construtores
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Medicamento()
        {
            codigomedicamento = 0;
            marca = "";
        }

        /// <summary>
        /// Construtor por parametros
        /// </summary>
        public Medicamento(int codigomedicamento, string marca,  int codigo, string nome, int fornecedor, int stock)
      : base(codigo, nome, fornecedor, stock)
        {
            this.codigomedicamento = codigomedicamento;
            this.marca = marca;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o código do Medicamento.
        /// </summary>
        public int CodigoMedicamento
        {
            get { return codigomedicamento; }
            set { codigomedicamento = value; }
           
        }

        /// <summary>
        /// Obtém ou define a marca do Medicamento.
        /// </summary>
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

      
        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga do operador de igualdade para Medicamentos.
        /// </summary>
        public static bool operator ==(Medicamento m1, Medicamento m2)
        {
            if ((m1.CodigoMedicamento == m2.CodigoMedicamento) && (m1.Marca == m2.Marca))
                return true;
            return false;
        }

        /// <summary>
        /// Sobrecarga do operador de desigualdade para Medicamentos.
        /// </summary>
        public static bool operator !=(Medicamento m1, Medicamento m2)
        {
            if (m1 == m2)
                return false;
            return true;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Retorna uma representação em string do objeto Medicamento.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - CodigoMedicamento: {2} - Fornecedor: {3} - Stock: {4}", Nome, Codigo.ToString(), codigomedicamento.ToString(), marca, Stock.ToString());
        }

        /// <summary>
        /// Determina se o objeto Medicamento é igual a outro objeto.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Medicamento)
            {
                Medicamento m = (Medicamento)obj;
                return this == m;
            }
            return false;
        }

        
  
        #endregion

        #endregion

    }
}
