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
    /// Classe responsável por gerenciar um conjunto de pessoas.
    /// </summary>
    public class Pessoas
    {
        private const int MAX_PESSOAS = 100; 
        private int totalPessoas; 
        private Pessoa[] pessoasArray; 

        /// <summary>
        /// Construtor padrão da classe Pessoas.
        /// Inicializa o array de pessoas e o contador de pessoas.
        /// </summary>
        public Pessoas()
        {
            pessoasArray = new Pessoa[MAX_PESSOAS]; 
            totalPessoas = 0; 
        }

        /// <summary>
        /// Propriedade estática somente leitura que retorna o número máximo de pessoas.
        /// </summary>
        public static int MaxPessoas { 
            get 
            { return MAX_PESSOAS; } 
        }

        /// <summary>
        /// Propriedade de leitura do array de pessoas (clone para evitar alterações externas).
        /// </summary>
        public Pessoa[] PessoasArray
        {
            get { return (Pessoa[])pessoasArray.Clone(); }
            set { } 
        }

        /// <summary>
        /// Propriedade de leitura do total de pessoas.
        /// </summary>
        public int TotalPessoas
        {
            get { return totalPessoas; }
        }

        /// <summary>
        /// Adiciona uma pessoa ao array na próxima posição disponível.
        /// </summary>
        /// <param name="pessoa">A pessoa a ser adicionada.</param>
        /// <returns>True se a pessoa foi adicionada com sucesso, False caso contrário.</returns>
        public bool AdicionarPessoa(Pessoa pessoa)
        {
            if (totalPessoas < MAX_PESSOAS)
            {
                pessoasArray[totalPessoas] = pessoa; 
                totalPessoas++; 
                return true; 
            }
            else
            {
                return false; 
            }
        }

        /// <summary>
        /// Remove uma pessoa com base no NIF.
        /// </summary>
        /// <param name="NIF">O NIF da pessoa a ser removida.</param>
        /// <returns>True se a pessoa foi removida com sucesso, False caso contrário.</returns>
        public bool RemoverPessoa(int NIF)
        {
            for (int i = 0; i < totalPessoas; i++)
            {
                if (pessoasArray[i].Nif == NIF)
                {
                    for (int j = i; j < totalPessoas - 1; j++)
                    {
                        pessoasArray[j] = pessoasArray[j + 1];
                    }
                    pessoasArray[totalPessoas - 1] = null;
                    totalPessoas--;
                    return true; 
                }
            }
            return false; 
        }

        /// <summary>
        /// Obtém o número total de pessoas.
        /// </summary>
        /// <returns>O número total de pessoas.</returns>
        public int ContaPessoa()
        {
            return totalPessoas;
        }
    }
}
