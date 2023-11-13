/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace Person
{
    public class Utente : Pessoa
    {
        #region Atributos
        int ContactoFamiliar;
        public string DataEntrada;
        #endregion

        #region Metodos

        #region Construtores
        // Construtor padrão
        public Utente()
        {
            ContactoFamiliar = 0;
            DataEntrada = "";
        }
        #endregion

        #region Propriedades
        // Propriedade para obter ou definir o contato familiar
        public int contactofamiliar
        {
            get { return ContactoFamiliar; }
            set { ContactoFamiliar = value; }
        }

        // Propriedade para obter ou definir a data de entrada
        public string dataentrada
        {
            get { return DataEntrada; }
            set { DataEntrada = value; }
        }
        #endregion

        #region Operadores
        // Sobrecarga do operador de igualdade
        public static bool operator ==(Utente u1, Utente u2)
        {
            // Comparação de atributos para determinar igualdade
            if ((u1.Nome == u2.Nome) && (u1.Nif == u2.Nif) && (u1.Apelido == u2.Apelido) && (u1.DataEntrada == u2.DataEntrada))
            {
                return true;
            }
            return false;
        }

        // Sobrecarga do operador de desigualdade
        public static bool operator !=(Utente u1, Utente u2)
        {
            return !(u1 == u2);
        }
        #endregion

        #region Overrides
        // Sobrescrita do método ToString para representação em string
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Data entrada: {2} - NIF: {3}", Nome, Idade.ToString(), DataEntrada.ToString(), Nif.ToString());
        }

        // Sobrescrita do método Equals para comparação de igualdade
        public override bool Equals(object obj)
        {
            if (obj is Utente)
            {
                Utente u = (Utente)obj;
                return this == u;
            }
            return false;
        }

        // Sobrescrita do método GetHashCode para geração de código hash
        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Nif, Apelido, DataEntrada);
        }
        #endregion

        #region Destruidores
        // Não há destruidores definidos
        #endregion

        #endregion
    }
}
