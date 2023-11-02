using PESSOA;

namespace UTENTE
{
    public class Utente : Pessoa
    {
        #region Atributos
        int ContactoFamiliar;
        string DataEntrada;

        #endregion

        #region Metodos

        #region Construtores
        public Utente()
        {
           
            ContactoFamiliar = 0;
            DataEntrada = "";
        }
        #endregion

        #region Propriedades
        
        public int contactofamiliar
        { get { return contactofamiliar; }
          set { contactofamiliar = value; } 
        }

        public string dataEntrada
        { get { return dataEntrada; } 
          set { dataEntrada = value; }
        }
        #endregion

        #region Operadores

        public static bool operator ==(Utente u1, Utente u2)
        { 
            if( (u1.Nome == u2.Nome) && (u1.Nif == u2.Nif) && (u1.Apelido == u2.Apelido) && (u1.dataEntrada == u2.dataEntrada) )
            {
                return true;
                
            }
            return false;
        }

        public static bool operator !=(Utente u1, Utente u2)
        {
            if (u1 != u2)
                return false; 
                return true;

        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Data entrada: {2} - NIF: {3}", Nome, Idade.ToString(), dataEntrada.ToString(), Nif.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is  Utente)
            {
                Utente u = (Utente)obj;
                if (this == u)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Destruidores
        #endregion

        #endregion


    }
}