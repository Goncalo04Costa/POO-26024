using PESSOA;
namespace FUNCIONARIO
{
    public class Funcionario
    {
        #region Atributos
        int codigo;
        string nome;
         int contacto;
        
        #endregion

        #region Metodos

        #region Construtores
        /// <summary>
        /// Construtor padrão da classe Funcionario.
        /// Inicializa os atributos com valores padrão.
        /// </summary>
        public Funcionario()
        {
            codigo = 0; 
            nome = "";
            contacto = 0;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o código do funcionário.
        /// </summary>
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }


        public virtual string MostraFuncionario()
        {
            return (String.Format("Nome: {0} - Codigo: {1} - Contacto{2}:", nome, codigo, contacto));

        }
        #endregion

        #region Operadores
        public static bool operator ==(Funcionario f1, Funcionario f2)
        {
            if ((f1.Nome == f2.Nome) && (f1.codigo == f2.codigo) && (f1.contacto == f2.contacto) )
                return true;
            return false;
        }

        public static bool operator !=(Funcionario f1, Funcionario f2)
        {
            //if (!((p1.Nome == p2.Nome) && (p1.idade == p2.idade)))
            if (f1 == f2)
                return false;
            return true;
            //ou
            //return (!(p1 == p2));
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            //return base.ToString();

            //return "Nome: " + nome + " Idade: " + idade;
            return String.Format("Nome: {0} - Codigo: {1} - Contacto{2}:", nome, codigo.ToString(),contacto.ToString() );
        }

        public override bool Equals(object obj)
        {
            if (obj is Funcionario)
            {
                Funcionario f = (Funcionario)obj;
                if (this == f)
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