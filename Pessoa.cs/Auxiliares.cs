using System;

namespace Person
{
    public class Auxiliares
    {
        private Auxiliar[] auxiliaresArray;
        private const int MAX_AUXILIARES = 52;
        private int totalAuxiliares;

        public Auxiliares()
        {
            auxiliaresArray = new Auxiliar[MAX_AUXILIARES];
            totalAuxiliares = 0;
        }

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


    }
}
