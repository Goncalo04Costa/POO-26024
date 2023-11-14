/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */



namespace Persons
{
    public class Utentes
    {
        private Utente[] utentesArray;
        private const int MAX_UTENTES = 52;
        private int totalUtentes;

        // Construtor padrão
        public Utentes()
        {
            utentesArray = new Utente[MAX_UTENTES];
            totalUtentes = 0;
        }

        // Propriedade estática para obter o máximo de utentes permitidos
        public static int MaxUtentes { get { return MAX_UTENTES; } }

        // Propriedade para obter uma cópia do array de utentes
        public Utente[] UtentesArray
        {
            get { return (Utente[])utentesArray.Clone(); }
            set { } // Evitar definir o valor diretamente, pois pode causar problemas de referência
        }

        // Propriedade para obter o total de utentes atualmente no array
        public int TotalUtentes
        {
            get { return totalUtentes; }
        }

        // Método para adicionar um utente ao array
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

        // Método para remover um utente com base no NIF
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

        // Método para contar o número de utentes no array
        public int ContarUtentes()
        {
            return totalUtentes;
        }
    }
}
