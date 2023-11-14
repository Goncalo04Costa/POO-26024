using Person;
using Product;
/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */
/*
namespace Unidade
{
    public class UCCI
    {
        #region Atributos
        const int MAXUTENTES = 52;
        const int MAXFUNCIONARIOS = 100;
        const int MAXDIRETORES = 1;
        const int MAXMEDICO = 2;
        private int numUtentes;
        private int numFuncionarios;
        private int numDiretores;
        private int numMedico;

        string nome;
        int capacidade;
        string morada;

       
        #endregion


        #region Metodos

        #region Construtores


        public UCCI()
        {
            utentes = new Utente[MAXUTENTES];
            funcionarios = new Funcionario[MAXFUNCIONARIOS];
            numUtentes = 0;
            numFuncionarios = 0;
            d = new Diretor();
            d.Nome = "";
            d.gabinete = -1;
            d.CodigoChefe = -1;
        }

        public UCCI(int maxUtentes = -1, int maxFuncionarios = -1)
        {
            if (maxUtentes != -1)
            {
                if (maxUtentes > MAXUTENTES)
                    utentes = new Utente[MAXUTENTES];
                else
                    utentes = new Utente[maxUtentes];
                d = new Diretor();
                d.Nome = "";
                d.gabinete = -1;
                d.CodigoChefe = -1;
                numUtentes = 0;
            }

            if (maxFuncionarios != -1)
            {
                if (maxFuncionarios > MAXFUNCIONARIOS)
                    funcionarios = new Funcionario[MAXFUNCIONARIOS];
                else
                    funcionarios = new Funcionario[maxFuncionarios];
                d = new Diretor();
                d.Nome = "";
                d.gabinete = -1;
                d.CodigoChefe = -1;
                numFuncionarios = 0;
            }
        }

        public UCCI(int maxUtentes, int maxFuncionarios, string nomeDir, int gabDir)
        {
            if (maxUtentes > MAXUTENTES && maxFuncionarios < MAXFUNCIONARIOS)
            {
                utentes = new Utente[MAXUTENTES];
                funcionarios = new Funcionario[MAXFUNCIONARIOS];
            }
            else
            {
                utentes = new Utente[maxUtentes];
                funcionarios = new Funcionario[maxFuncionarios];
            }

            for (int i = 0; i < maxUtentes; i++)
            {
                utentes[i] = new Utente();
            }

            for (int i = 0; i < maxFuncionarios; i++)
            {
                funcionarios[i] = new Funcionario();
            }
            d = new Diretor();
            d.Nome = nomeDir;
            d.gabinete = gabDir;
            numUtentes = 0;
            numFuncionarios = 0;
        }
        #endregion

        #endregion

        #region Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }
        public Utente[] Utentes
        {
            get { return utentes; }
            set { utentes = value; }
        }

        public Funcionario[] Funcionarios
        {
            get { return funcionarios; }
            set { funcionarios = value; }
        }

        public Diretor[] Diretores
        {
            get { return diretores; }
            set { diretores = value; }
        }
        #endregion

        #region Operadores
        public static bool operator ==(UCCI u1, UCCI u2)
        {
            return u1.nome == u2.nome && u1.capacidade == u2.capacidade && u1.morada == u2.morada;
        }

        public static bool operator !=(UCCI u1, UCCI u2)
        {
            return !(u1 == u2);
        }
        #endregion

        #region Overrides
        #region Overrides
        public override string ToString()
        {
            return $"UCCI: {nome} - Capacidade: {capacidade} - Morada: {morada}";
        }

        public override bool Equals(object obj)
        {
            if (obj is UCCI other)
            {
                return this.nome == other.nome && this.capacidade == other.capacidade && this.morada == other.morada;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nome, capacidade, morada);
        }
        #endregion
        #endregion

        #region Destruidores
        #endregion

        public void AdicionarUtente(Utente novoUtente)
        {
            if (numUtentes < MAXUTENTES)
            {
                utentes[numUtentes] = novoUtente;
                numUtentes++;
            }
            else
            {
                Console.WriteLine("Capacidade máxima de utentes atingida.");
            }
        }

        public void RemoverUtente(Utente utenteARemover)
        {
            for (int i = 0; i < numUtentes; i++)
            {
                if (utentes[i] == utenteARemover)
                {
                    for (int j = i; j < numUtentes - 1; j++)
                    {
                        utentes[j] = utentes[j + 1];
                    }
                    utentes[numUtentes - 1] = null;
                    numUtentes--;
                    break;
                }
            }
        }

        public void ListarUtentes()
        {
            for (int i = 0; i < numUtentes; i++)
            {
                Console.WriteLine(utentes[i].ToString());
            }
        }



    }
}
*/

namespace UCCI
{
    public class UCCI
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Pessoa  pessoa = new Pessoa();
        }
    }
}