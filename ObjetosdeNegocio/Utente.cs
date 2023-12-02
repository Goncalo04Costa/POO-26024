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
    public class Utente : Pessoa
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
        /// Propriedade para obter ou definir o contato familiar do Utente.
        /// </summary>
        public int ContactoFamiliarProperty
        {
            get { return ContactoFamiliar; }
            set { ContactoFamiliar = value; }
        }

        /// <summary>
        /// Propriedade para obter ou definir a data de entrada do Utente.
        /// </summary>
        public string DataEntradaProperty
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
            if (ReferenceEquals(u1, null) || ReferenceEquals(u2, null))
            {
                return false; 
            }

            if ((u1.Nome == u2.Nome) && (u1.Nif == u2.Nif) && (u1.Apelido == u2.Apelido))
            {
                return true; 
            }

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
        /// Sobrescrita do método GetHashCode para geração do código hash.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
