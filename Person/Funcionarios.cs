using System;

namespace Person
{
    public class Funcionarios
    {
        private Funcionario[] funcionariosArray;
        private const int MAX_FUNCIONARIOS = 52;
        private int totalFuncionarios;

   
        public Funcionarios()
        {
            funcionariosArray = new Funcionario[MAX_FUNCIONARIOS];
            totalFuncionarios = 0;
        }

        public static int MaxFuncionarios { get { return MAX_FUNCIONARIOS; } }

        public Funcionario[] FuncionariosArray
        {
            get { return (Funcionario[])funcionariosArray.Clone(); }
            set { } // EVITAR!
        }

        public int TotalFuncionarios
        {
            get { return totalFuncionarios; }
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (totalFuncionarios < MAX_FUNCIONARIOS)
            {
                funcionariosArray[totalFuncionarios] = funcionario;
                totalFuncionarios++;
            }
            else
            {
                Console.WriteLine("O limite máximo de funcionários foi atingido. Não é possível adicionar mais funcionários.");
            }
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine("Lista de Funcionários:");
            foreach (Funcionario funcionario in funcionariosArray)
            {
                if (funcionario != null)
                {
                    Console.WriteLine(funcionario.ToString());
                }
            }
        }

        public void QuickSort(Funcionario[] arr, int left, int right)
        {
            int i = left, j = right;
            Funcionario pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (String.Compare(arr[i].Nome, pivot.Nome, StringComparison.Ordinal) < 0)
                {
                    i++;
                }

                while (String.Compare(arr[j].Nome, pivot.Nome, StringComparison.Ordinal) > 0)
                {
                    j--;
                }

                if (i <= j)
                { 
                    Funcionario tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            }

            // Recursão
            if (left < j)
            {
                QuickSort(arr, left, j);
            }

            if (i < right)
            {
                QuickSort(arr, i, right);
            }
        }

        public void ListarFuncionariosOrdenados()
        {
            QuickSort(funcionariosArray, 0, totalFuncionarios - 1);

            Console.WriteLine("Lista de Funcionários por Ordem Alfabética:");
            foreach (Funcionario funcionario in funcionariosArray)
            {
                if (funcionario != null)
                {
                    Console.WriteLine(funcionario.ToString());
                }
            }
        }

    }
}