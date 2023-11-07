using System;

namespace Person
{
    public class Pessoas
    {
        private const int MAX_PESSOAS = 100;
        private int totalPessoas;
        private Pessoa[] pessoasArray;

        public Pessoas()
        {
            pessoasArray = new Pessoa[MAX_PESSOAS];
            totalPessoas = 0;
        }

        public static int MaxPessoas { get { return MAX_PESSOAS; } }

        public Pessoa[] PessoasArray
        {
            get { return (Pessoa[])pessoasArray.Clone(); }
            set { } // EVITAR!
        }

        public int TotalPessoas
        {
            get { return totalPessoas; }
        }


        public void AdicionarPessoa(int index, Pessoa pessoa)
        {
            if (index >= 0 && index < pessoasArray.Length)
            {
                pessoasArray[index] = pessoa;
            }
            else
            {
                Console.WriteLine("ERRO!");
            }
        }

        public void ListarPessoas()
        {
            Console.WriteLine("Lista de Pessoas:");
            foreach (Pessoa pessoa in pessoasArray)
            {
                if (pessoa != null)
                {
                    Console.WriteLine(pessoa.ToString());
                }
            }
        }
    }
}
