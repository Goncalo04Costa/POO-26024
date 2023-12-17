﻿/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Classe que representa um produto de limpeza, derivada da classe Produto.
    /// </summary>
    public class Limpeza : Produto
    {
        #region Atributos
        int referencia;
        string descricao;
        #endregion


        #region metodos

        #region Construtores
        /// <summary>
        /// Construtor padrão da classe Limpeza.
        /// </summary>
        public Limpeza()
        {
            referencia = 0;
            descricao = "";
        }

        public Limpeza(int referencia, string descricao, string nome,int codigo,int fornecedor, int stock)
         : base(codigo ,nome, fornecedor, stock)
        {
            this.referencia = referencia;
            this.descricao = descricao;
        }


        #endregion

        #region Propriedades
        /// <summary>
        /// Propriedade para obter ou definir a referência do produto de limpeza.
        /// </summary>
        public int Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        /// <summary>
        /// Propriedade para obter ou definir a descrição do produto de limpeza.
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar produtos de limpeza.
        /// </summary>
        public static bool operator ==(Limpeza l1, Limpeza l2)
        {
            if ((l1.Descricao == l2.Descricao) && (l1.Referencia == l2.Referencia))
                return true;
            return false;
        }

        /// <summary>
        /// Sobrecarga do operador de desigualdade para comparar produtos de limpeza.
        /// </summary>
        public static bool operator !=(Limpeza l1, Limpeza l2)
        {
            if (l1 == l2)
                return false;
            return true;
        }
        #endregion

        #region OutrosMetodos

        /// <summary>
        /// Sobrescrita do método ToString para representação em string do objeto de Limpeza.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Codigo: {1} - Referencia: {2} - Descrição: {3} - Stock: {4}", Nome, Codigo.ToString(), referencia.ToString(), descricao, Stock.ToString());
        }

        /// <summary>
        /// Sobrescrita do método Equals para comparação de igualdade do objeto de Limpeza.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Limpeza)
            {
                Limpeza l = (Limpeza)obj;
                return this == l;
            }
            return false;
        }
        #endregion
#endregion

    }
}
