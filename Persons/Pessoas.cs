/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */


namespace Persons
{
    // Definição da classe Pessoas
    public class Pessoas
    {
        
        private const int MAX_PESSOAS = 100;
        private int totalPessoas;
        private Pessoa[] pessoasArray;

        // Construtor padrão da classe Pessoas
        public Pessoas()
        {
            pessoasArray = new Pessoa[MAX_PESSOAS];
            totalPessoas = 0;
        }

        // Propriedade de leitura estática que retorna o número máximo de pessoas
        public static int MaxPessoas { get { return MAX_PESSOAS; } }

        // Propriedade de leitura do array de pessoas (clone para evitar alterações externas)
        public Pessoa[] PessoasArray
        {
            get { return (Pessoa[])pessoasArray.Clone(); }
            set { } 
        }

        // Propriedade de leitura do total de pessoas
        public int TotalPessoas
        {
            get { return totalPessoas; }
        }

        // Método para adicionar uma pessoa ao array na posição especificada
        public void AdicionarPessoa(Pessoa pessoa)
        {
            if (totalPessoas < MAX_PESSOAS)
            {
                pessoasArray[totalPessoas] = pessoa;
                totalPessoas++;
            }
            else
            {}
        }

        // Método para remover uma pessoa com o NIF especificado do array
        public void RemoverPessoa(int NIF)
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
                    return;
                }
            }
        }

        // Método para obter o número total de pessoas
        public int ContaPessoa()
        {
            return totalPessoas;
        }
    }
}
