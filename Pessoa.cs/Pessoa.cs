namespace PESSOA
{
    public class Pessoa
    {
        #region Atributos
        string nome;
        string apelido;
        int idade;
        int NIF;
        int SNS;
        int contacto;
        #endregion

        #region Metodos

        #region Construtores
        public  Pessoa()
        {
             nome = "";
            apelido = "";
            idade = 0;
            NIF = 0;
            SNS = 0;
            contacto = 0;
        }
        #endregion


        #region Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public int Nif
        {
            get { return NIF; }
            set { NIF = value; }
        }

        public int Sns
        {
            get { return SNS; }
            set { SNS = value; }
        }

        public int Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        #endregion

        #region Operadores
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            if ((p1.nome == p2.nome) && (p1.apelido == p2.apelido) && (p1.contacto == p2.contacto) && (p1.idade == p2.idade) && (p1.NIF == p2.NIF) && (p1.SNS == p2.SNS)) 
                return true;
            return false;
        }

        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
           
            if (p1 == p2)
                return false;
            return true;
         
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            
            return String.Format("Nome: {0}{1} - Idade: {2} - Contacto{3} - NIF:{4} - SNS:{5}", nome, apelido, idade.ToString(), contacto.ToString(), NIF.ToString(), SNS.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is Pessoa)
            {
                Pessoa p = (Pessoa)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region Destruidores
        #endregion

        #endregion


    }
}