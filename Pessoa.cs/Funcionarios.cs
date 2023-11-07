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

        // Outros métodos de gerenciamento do array de funcionários podem ser adicionados aqui.

    }
}
