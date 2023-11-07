using System;

namespace Person
{
    public class Utentes
    {
        private Utente[] utentesArray;
        private const int MAX_UTENTES = 52;
        private int totalUtentes;

        public Utentes()
        {
            utentesArray = new Utente[MAX_UTENTES];
            totalUtentes = 0;
        }

        public void AdicionarUtente(Utente utente)
        {
            if (totalUtentes < MAX_UTENTES)
            {
                utentesArray[totalUtentes] = utente;
                totalUtentes++;
            }
            else
            {
                Console.WriteLine("O limite máximo de utentes foi atingido. Não é possível adicionar mais utentes.");
            }
        }

        public void ListarUtentes()
        {
            Console.WriteLine("Lista de Utentes:");
            foreach (Utente utente in utentesArray)
            {
                if (utente != null)
                {
                    Console.WriteLine(utente.ToString());
                }
            }
        }

    }
}
