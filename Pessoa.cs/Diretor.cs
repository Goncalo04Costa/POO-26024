namespace Person
{
    public class Diretor : Funcionario
    {
        #region Atributos
        int codigochefe;
        int Gabinete;
        #endregion
        #region Metodos
        #region Construtores
        public Diretor()
        {
            codigochefe = 0;
            Gabinete = 0;
        }

        public Diretor(int gab, int codf, string nome, string apelido, int idade, int nif, int sns, int contacto)
            
        {
            Gabinete = gab;
            codigochefe = codf;
        }
        #endregion

        #region Propriedades
        public int gabinete
        {
            get { return Gabinete; }
            set { Gabinete = value; }
        }

        public int CodigoChefe
        {
            get { return codigochefe; }
            set { codigochefe = value; }
        }
        #endregion

        #region Operadores
        // Mantenha os operadores conforme necessário
        #endregion

        #region Overrides
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} - Gabinete: {2} - Codigo: {3}}", Nome, gabinete.ToString(), codigochefe.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is Diretor)
            {
                Diretor other = (Diretor)obj;
                return base.Equals(obj) && this.codigochefe == other.codigochefe && this.Gabinete == other.Gabinete;
            }
            return false;
        }

        public override int GetHashCode()
        {
            // Implemente um cálculo de código hash mais específico levando em consideração os atributos relevantes da classe Diretor
            return base.GetHashCode();
        }
        #endregion

        #region Destruidores
        // Mantenha os destruidores conforme necessário
        #endregion
        #endregion
    }

}
