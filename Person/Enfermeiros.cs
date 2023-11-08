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

        public void RemoverEnfermeiro(int codigoEnfermeiro)
        {
            for (int i = 0; i < totalEnfermeiros; i++)
            {
                if (enfermeirosArray[i].codigoEnfermeiro == codigoEnfermeiro)
                {
                    for (int j = i; j < totalEnfermeiros - 1; j++)
                    {
                        enfermeirosArray[j] = enfermeirosArray[j + 1];
                    }
                    enfermeirosArray[totalEnfermeiros - 1] = null; // Limpar a última posição
                    totalEnfermeiros--;
                    Console.WriteLine("Enfermeiro removido com sucesso.");
                    return;
                }
            }
            Console.WriteLine("Enfermeiro não encontrado.");
        }

        public int ContarEnfermeiros()
        {
            return totalEnfermeiros;
        }

        #endregion
    }
}
