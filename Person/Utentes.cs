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

        public static int MaxUtentes { get { return MAX_UTENTES; } }

        public Utente[] UtentesArray
        {
            get { return (Utente[])utentesArray.Clone(); }
            set { } // EVITAR!
        }

        public int TotalUtentes
        {
            get { return totalUtentes; }
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

        public void OrdenarPorDataEntrada()
        {
            for (int i = 0; i < totalUtentes - 1; i++)
            {
                for (int j = 0; j < totalUtentes - i - 1; j++)
                {
                    if (DateTime.Parse(utentesArray[j].DataEntrada) > DateTime.Parse(utentesArray[j + 1].DataEntrada))
                    {
                        Utente temp = utentesArray[j];
                        utentesArray[j] = utentesArray[j + 1];
                        utentesArray[j + 1] = temp;
                    }
                }
            }
        }


    }
}
