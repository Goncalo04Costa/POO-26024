/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */


namespace Persons
{
    /// <summary>
    /// A classe Funcionarios gerencia um array de funcionários.
    /// </summary>
    public class Funcionarios
    {
        private Funcionario[] funcionariosArray;
        private const int MAX_FUNCIONARIOS = 52;
        private int totalFuncionarios;

        /// <summary>
        /// Construtor da classe Funcionarios.
        /// </summary>
        public Funcionarios()
        {
            funcionariosArray = new Funcionario[MAX_FUNCIONARIOS];
            totalFuncionarios = 0;
        }

        /// <summary>
        /// Obtém o número máximo de funcionários.
        /// </summary>
        public static int MaxFuncionarios { get { return MAX_FUNCIONARIOS; } }

        /// <summary>
        /// Obtém uma cópia do array de funcionários.
        /// </summary>
        public Funcionario[] FuncionariosArray
        {
            get { return (Funcionario[])funcionariosArray.Clone(); }
            set { } 
        }

        /// <summary>
        /// Obtém o número total de funcionários.
        /// </summary>
        public int TotalFuncionarios
        {
            get { return totalFuncionarios; }
        }

        /// <summary>
        /// Adiciona um funcionário ao array.
        /// </summary>
        /// <param name="funcionario">O funcionário a ser adicionado.</param>
        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            if (totalFuncionarios < MAX_FUNCIONARIOS)
            {
                funcionariosArray[totalFuncionarios] = funcionario;
                totalFuncionarios++;
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public bool RemoverFuncionario(int NIF)
        {
            for (int i = 0; i < totalFuncionarios; i++)
            {
                if (funcionariosArray[i].Nif == NIF)
                {
                    for (int j = i; j < totalFuncionarios - 1; j++)
                    {
                        funcionariosArray[j] = funcionariosArray[j + 1];
                    }
                    funcionariosArray[totalFuncionarios - 1] = null;
                    totalFuncionarios--;
                    return true; 
                }
            }

            return false; 
        }

        /// <summary>
        /// Retorna o número atual de funcionários no array.
        /// </summary>
        /// <returns>O número atual de funcionários.</returns>
        public int ContaFuncionario()
        {
            return totalFuncionarios;
        }
    }
}
