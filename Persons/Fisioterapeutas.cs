namespace Persons
{
    public class Fisioterapeutas
    {
        private Fisioterapeuta[] fisioArray; // Array para armazenar objetos Enfermeiro
        private const int MAX_FISIOTERAPEUTAS = 2; // Número máximo de enfermeiros permitidos
        private int totalFisioterapeutas; // Número atual de enfermeiros na coleção

        /// <summary>
        /// Construtor padrão para a classe Enfermeiros.
        /// Inicializa o array de Enfermeiro e define o número total de enfermeiros como zero.
        /// </summary>
        public Fisioterapeutas()
        {
            fisioArray = new Fisioterapeuta[MAX_FISIOTERAPEUTAS];
            totalFisioterapeutas = 0;
        }

        /// <summary>
        /// Obtém o número máximo de enfermeiros permitidos.
        /// </summary>
        public static int MaxFisios { get { return MAX_FISIOTERAPEUTAS; } }

        /// <summary>
        /// Obtém uma cópia do array de Enfermeiro.
        /// </summary>
        public Fisioterapeuta[] FisioArray
        {
            get { return (Fisioterapeuta[])fisioArray.Clone(); }
            set { } 
        }

        /// <summary>
        /// Obtém o número total de enfermeiros na coleção.
        /// </summary>
        public int TotalFisios
        {
            get { return totalFisioterapeutas; }
        }

        #region Outros Métodos

        /// <summary>
        /// Adiciona um objeto Enfermeiro à coleção.
        /// </summary>
        /// <param name="enfermeiro">O objeto Enfermeiro a ser adicionado.</param>
        public void AdicionarFisioterapeuta(Fisioterapeuta fisioterapeuta)
        {
            if (totalFisioterapeutas < MAX_FISIOTERAPEUTAS)
            {
                fisioArray[totalFisioterapeutas] = fisioterapeuta;
                totalFisioterapeutas++;
            }
            else
            {
                Console.WriteLine("O limite máximo de enfermeiros foi atingido. Não é possível adicionar mais enfermeiros.");
            }
        }

        /// <summary>
        /// Remove um objeto Enfermeiro da coleção com base no código do enfermeiro.
        /// </summary>
        /// <param name="codigoEnfermeiro">O código do Enfermeiro a ser removido.</param>
        public void Removerfisio(int codigofisioterapeuta)
        {
            for (int i = 0; i < totalFisioterapeutas; i++)
            {
                if (fisioArray[i].CodigoFisioterapeuta == codigofisioterapeuta)
                {
                    for (int j = i; j < totalFisioterapeutas - 1; j++)
                    {
                        fisioArray[j] = fisioArray[j + 1];
                    }
                    fisioArray[totalFisioterapeutas - 1] = null; // Limpar a última posição
                    totalFisioterapeutas--;
                    Console.WriteLine("Enfermeiro removido com sucesso.");
                    return;
                }
            }
            Console.WriteLine("Enfermeiro não encontrado.");
        }

        /// <summary>
        /// Conta e retorna o número total de enfermeiros na coleção.
        /// </summary>
        /// <returns>O número total de enfermeiros.</returns>
        public int ContaFisios()
        {
            return totalFisioterapeutas;
        }

        #endregion
    }
}

