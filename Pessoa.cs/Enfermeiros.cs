using System;

namespace Person
{
    public class Enfermeiros
    {
        private Enfermeiro[] enfermeirosArray;
        private const int MAX_ENFERMEIROS = 24;
        private int totalEnfermeiros;

        public Enfermeiros()
        {
            enfermeirosArray = new Enfermeiro[MAX_ENFERMEIROS];
            totalEnfermeiros = 0;
        }

        public static int MaxEnfermeiros { get { return MAX_ENFERMEIROS; } }

        public Enfermeiro[] EnfermeirosArray
        {
            get { return (Enfermeiro[])enfermeirosArray.Clone(); }
            set { } // EVITAR!
        }

        public int TotalEnfermeiros
        {
            get { return totalEnfermeiros; }
        }
        

        #region OtherMethods
        public void AdicionarEnfermeiro(Enfermeiro enfermeiro)
        {
            if (totalEnfermeiros < MAX_ENFERMEIROS)
            {
                enfermeirosArray[totalEnfermeiros] = enfermeiro;
                totalEnfermeiros++;
            }
            else
            {
                Console.WriteLine("O limite máximo de enfermeiros foi atingido. Não é possível adicionar mais enfermeiros.");
            }
        }

        public void ListarEnfermeiros()
        {
            Console.WriteLine("Lista de Enfermeiros:");
            foreach (Enfermeiro enfermeiro in enfermeirosArray)
            {
                if (enfermeiro != null)
                {
                    Console.WriteLine(enfermeiro.ToString());
                }
            }
        }

        public void ListarEnfermeirosPorCondicao(string condicao)
        {
            Console.WriteLine($"Lista de Enfermeiros com a Condição {condicao}:");
            foreach (Enfermeiro enfermeiro in enfermeirosArray)
            {
                if (enfermeiro != null && enfermeiro.condicao == condicao)
                {
                    Console.WriteLine(enfermeiro.ToString());
                }
            }
        }


        private void Ordenar()
        {
            for (int i = 0; i < totalEnfermeiros - 1; i++)
            {
                for (int j = 0; j < totalEnfermeiros - i - 1; j++)
                {
                    if (enfermeirosArray[j].codigoEnfermeiro < enfermeirosArray[j + 1].codigoEnfermeiro)
                    {
                        // Troca os elementos se o primeiro for menor que o próximo
                        Enfermeiro temp = enfermeirosArray[j];
                        enfermeirosArray[j] = enfermeirosArray[j + 1];
                        enfermeirosArray[j + 1] = temp;
                    }
                }
            }
        }

        public void ListarEnfermeirosOrdenados()
        {
            // Ordenar os enfermeiros usando o Bubble Sort
            Ordenar();

            Console.WriteLine("Lista de Enfermeiros por Ordem Decrescente de Código:");
            foreach (Enfermeiro enfermeiro in enfermeirosArray)
            {
                if (enfermeiro != null)
                {
                    Console.WriteLine(enfermeiro.ToString());
                }
            }
        }
        #endregion
    }
}
