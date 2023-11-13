/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */
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

        public void RemoverUtente(int NIF)
        {
            for (int i = 0; i < totalUtentes; i++)
            {
                if (utentesArray[i].Nif == NIF)
                {
                    for (int j = i; j < totalUtentes - 1; j++)
                    {
                        utentesArray[j] = utentesArray[j + 1];
                    }
                    utentesArray[totalUtentes - 1] = null;
                    totalUtentes--;
                    return;
                }
            }
        }

        public int ContarUtentes()
        {
            return totalUtentes;
        }



    }
}
