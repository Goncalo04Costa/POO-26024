/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Representa um equipamento com atributos como código, nome, descrição, carga e estado.
    /// </summary>
        [Serializable]
    public class Equipamento : IEquipamento
    {
        #region Atributos
        int codigo;
        string nome;
        string descricao;
        int carga;
        int estado;
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Equipamento()
        {
            codigo = 0;
            nome = "";
            descricao = "";
            carga = 0;
            estado = 0;
        }

        public Equipamento(int codigo, string nome, string descricao, int carga, int estado)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.descricao = descricao;
            this.carga = carga;
            this.estado = estado;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o código do equipamento.
        /// </summary>
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do equipamento.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do equipamento.
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Obtém ou define o estado atual do equipamento.
        /// </summary>
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Obtém ou define a carga do equipamento.
        /// </summary>
        public int Carga
        {
            get { return carga; }
            set { carga = value; }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Verifica se dois equipamentos são iguais, comparando seus atributos.
        /// </summary>
        /// <param name="e1">O primeiro equipamento a ser comparado.</param>
        /// <param name="e2">O segundo equipamento a ser comparado.</param>
        /// <returns>Retorna verdadeiro se os equipamentos forem iguais, caso contrário, falso.</returns>
        public static bool operator ==(Equipamento e1, Equipamento e2)
        {
            if ((e1.Codigo == e2.Codigo) && (e1.Nome == e2.Nome) && (e1.Descricao == e2.Descricao) && (e1.Carga == e2.Carga) && (e1.Estado == e2.Estado))
                return true;
            return false;
        }

        /// <summary>
        /// Verifica se dois equipamentos são diferentes, comparando seus atributos.
        /// </summary>
        /// <param name="e1">O primeiro equipamento a ser comparado.</param>
        /// <param name="e2">O segundo equipamento a ser comparado.</param>
        /// <returns>Retorna verdadeiro se os equipamentos forem diferentes, caso contrário, falso.</returns>
        public static bool operator !=(Equipamento e1, Equipamento e2)
        {
            return !(e1 == e2);
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Retorna uma representação em string do objeto Equipamento.
        /// </summary>
        /// <returns>Retorna uma string formatada com os detalhes do equipamento.</returns>
        public override string ToString()
        {
            return String.Format("Codigo: {0} - Nome: {1} - Descrição: {2} - Carga: {3} - Estado:{4}", codigo.ToString(), nome, descricao, carga.ToString(), estado.ToString());
        }

        /// <summary>
        /// Determina se o objeto Equipamento é igual a outro objeto.
        /// </summary>
        /// <param name="obj">O objeto a ser comparado com o equipamento atual.</param>
        /// <returns>Retorna verdadeiro se os objetos forem iguais, caso contrário, falso.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Equipamento)
            {
                Equipamento e = (Equipamento)obj;
                return this == e;
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
    }
}
