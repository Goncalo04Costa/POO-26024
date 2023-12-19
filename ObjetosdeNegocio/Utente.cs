/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Classe que representa um Utente, derivada da classe Pessoa.
    /// </summary>
    [Serializable]
    public class Utente : Pessoa, IComparable<Utente>
    {
        int ContactoFamiliar;
        string DataEntrada;
        string avaliacaomedica;
        int estado;


        /// <summary>
        /// Construtor padrão da classe Utente.
        /// </summary>
        public Utente()
        {
            ContactoFamiliar = 0;
            DataEntrada = "";
            avaliacaomedica = "";
            estado = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="contactoFamiliar"></param>
        /// <param name="dataEntrada"></param>
        /// <param name="avaliacaomedica"></param>
        /// <param name="estado"></param>
        /// <param name="nome"></param>
        /// <param name="apelido"></param>
        /// <param name="idade"></param>
        /// <param name="NIF"></param>
        /// <param name="SNS"></param>

        public Utente(int contactoFamiliar, string dataEntrada, string avaliacaomedica, int estado, string nome, string apelido, int idade, int NIF, int SNS)
           : base(nome, apelido, idade, NIF, SNS)
        {
            this.ContactoFamiliar = contactoFamiliar;
            this.DataEntrada = dataEntrada;
            this.avaliacaomedica = avaliacaomedica;
            this.Estado = estado;
        
        }



        /// <summary>
        /// Propriedade para obter ou definir o contato familiar do Utente.
        /// </summary>
        public int Contactofamiliar
        {
            get { return ContactoFamiliar; }
            set { ContactoFamiliar = value; }
        }

        /// <summary>
        /// Propriedade para obter ou definir a data de entrada do Utente.
        /// </summary>
        public string DatadeEntrada
        {
            get { return DataEntrada; }
            set { DataEntrada = value; }
        }

        /// <summary>
        /// Propriedade para obter ou definir a avaliação médica do Utente.
        /// </summary>
        public string AvaliacaoMedica
        {
            get { return avaliacaomedica; }
            set { avaliacaomedica = value; }
        }

        /// <summary>
        /// Propriedade para obter ou definir o contato familiar do Utente.
        /// </summary>
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar Utentes.
        /// </summary>
        public static bool operator ==(Utente u1, Utente u2)
        {
            if ((u1.Nome == u2.Nome) && (u1.Apelido == u2.Apelido) && (u1.Idade == u2.Idade) && (u1.Sns == u2.Sns) && (u1.avaliacaomedica == u2.avaliacaomedica) && (u1.ContactoFamiliar == u2.ContactoFamiliar) && (u1.avaliacaomedica == u2.avaliacaomedica))
                return true;
            return false;
        }


        /// <summary>
        /// Sobrecarga do operador de desigualdade para comparar Utentes.
        /// </summary>
        public static bool operator !=(Utente u1, Utente u2)
        {
            return !(u1 == u2);
        }

        /// <summary>
        /// Sobrescrita do método ToString para representação em string.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Data entrada: {2} - NIF: {3} - Avaliacao: {4}", Nome, Idade.ToString(), DataEntrada.ToString(), Nif.ToString(), avaliacaomedica);
        }

        /// <summary>
        /// Sobrescrita do método Equals para comparação de igualdade.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Utente)
            {
                Utente u = (Utente)obj;
                return this == u;
            }
            return false;
        }


        /// <summary>
        /// Método para comparar utentes com base na data.
        /// </summary>
        /// <param name="other">Outro Utente a ser comparada.</param>
        /// <returns>Um valor inteiro que indica a relação entre as datas.</returns>
        public int CompareTo(Utente other)
        {
            // Verifica se o objeto other é nulo
            if (other == null) return 1;

            // Comparação das datas
            return this.DataEntrada.CompareTo(other.DataEntrada);
        }


    }
}
