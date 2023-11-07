using System;

namespace Person
{
    public class Auxiliares
    {
         Auxiliar[] auxiliaresArray;
         const int MAX_AUXILIARES = 52;
         int totalAuxiliares;

        public Auxiliares()
        {
            auxiliaresArray = new Auxiliar[MAX_AUXILIARES];
            totalAuxiliares = 0;
        }

        public static int MaxAuxiliares { get { return MAX_AUXILIARES; } }

        public Auxiliar[] AuxiliaresArray
        {
            get { return (Auxiliar[])auxiliaresArray.Clone(); }
            set { } // EVITAR!
        }

        public int TotalAuxiliares
        {
            get { return totalAuxiliares; }
        }
        #region Othermethods
        public void AdicionarAuxiliar(Auxiliar auxiliar)
        {
            if (totalAuxiliares < MAX_AUXILIARES)
            {
                auxiliaresArray[totalAuxiliares] = auxiliar;
                totalAuxiliares++;
            }
            else
            {
                Console.WriteLine("O limite máximo de auxiliares foi atingido. Não é possível adicionar mais auxiliares.");
            }
        }

        public void ListarAuxiliares()
        {
            Console.WriteLine("Lista de Auxiliares:");
            foreach (Auxiliar auxiliar in auxiliaresArray)
            {
                if (auxiliar != null)
                {
                    Console.WriteLine(auxiliar.ToString());
                }
            }
        }

        public Auxiliar PesquisarPorNome(string nome)
        {
            foreach (Auxiliar auxiliar in auxiliaresArray)
            {
                if (auxiliar != null && auxiliar.Nome == nome)
                {
                    return auxiliar;
                }
            }
            return null; 
        }

        public int ContarAuxiliares()
        {
            int count = 0;
            foreach (Auxiliar auxiliar in auxiliaresArray)
            {
                if (auxiliar != null)
                {
                    count++;
                }
            }
            return count;
        }


        private void ReorganizarArray()
        {
            Auxiliar[] tempArray = new Auxiliar[MAX_AUXILIARES];
            int index = 0;
            for (int i = 0; i < totalAuxiliares; i++)
            {
                if (auxiliaresArray[i] != null)
                {
                    tempArray[index] = auxiliaresArray[i];
                    index++;
                }
            }
            auxiliaresArray = tempArray;
        }




        public bool RemoverAuxiliar(string nome)
        {
            for (int i = 0; i < totalAuxiliares; i++)
            {
                if (auxiliaresArray[i] != null && auxiliaresArray[i].Nome == nome)
                {
                    auxiliaresArray[i] = null;
                    ReorganizarArray(); 
                    totalAuxiliares--;
                    return true;
                }
            }
            return false;
        }


        public void ListarAuxiliaresPorCondicao(string Condicao)
        {
            Console.WriteLine($"Lista de Auxiliares com a Condição {Condicao}:");
            foreach (Auxiliar auxiliar in auxiliaresArray)
            {
                if (auxiliar != null && auxiliar.condicao == Condicao)
                {
                    Console.WriteLine(auxiliar.ToString());
                }
            }
        }


        #endregion
    }
}
