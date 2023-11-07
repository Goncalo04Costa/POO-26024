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

        // Outros métodos de gerenciamento do array de enfermeiros podem ser adicionados aqui.

    }
}
