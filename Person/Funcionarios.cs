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


        public void RemoverFuncionario(int NIF)
        {

            for (int i = 0; i < totalFuncionarios; i++)
            {
                if (funcionariosArray[i].Nif == NIF)
                {
                    for (int j = i; j < totalFuncionarios - 1; j++)
                    {
                        funcionariosArray[j] = funcionariosArray[j + 1];
                    }
                    funcionariosArray[totalFuncionarios - 1] = null;
                    totalFuncionarios--;
                    return;
                }
            }
        }

        public int ContaFuncionario()
        {
            return totalFuncionarios;
        }
    }



}
