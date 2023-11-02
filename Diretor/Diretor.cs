namespace DIRETOR
{
    public class Diretor
    {
        #region Atributos
        
        string Nome;
        int Gabinete;
        #endregion

        #region Metodos

        #region Construtores
        public Diretor()
            {
            string Nome = "";
            int Gabinete = 0;
            }

        public Diretor(string no, int gab)
        {
            Nome = no;
            Gabinete = gab;
        }

        #endregion

        #region Propriedades

        public int gabinete
        {
            get { return Gabinete; }
            set { Gabinete = value; }
        }

        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        #endregion

        #region Operadores
        
        #endregion

        #region Overrides
        #endregion

        #region Destruidores
        #endregion

        #endregion


    }
}