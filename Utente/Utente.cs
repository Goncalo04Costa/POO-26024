namespace UTENTE
{
    public class Utente
    {
        #region Atributos
        int NIF;
        string Nome;
        string Apelido;
        int Idade;
        int ContactoFamiliar;
        string DataEntrada;

        #endregion

        #region Metodos

        #region Construtores
        public Utente()
        {
            NIF = 0;
            Nome = "";
            Apelido = "";
            Idade = 0;
            ContactoFamiliar = 0;
            DataEntrada = "";
        }
        #endregion

        #region Propriedades

        public int nif
        {
            get { return NIF; }
            set { NIF = value; }
        }
        public string nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }
    
        public int idade
        {
            get { return idade; }
            set { idade = value; }
        }
        
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
            if( (u1.nome == u2.nome) && (u1.nif == u2.nif) && (u1.apelido == u2.apelido) && (u1.dataEntrada == u2.dataEntrada) )
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
            return String.Format("Nome: {0} - Idade: {1} - Data entrada: {2} - NIF: {3}", nome, idade.ToString(), dataEntrada.ToString(), nif.ToString());
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