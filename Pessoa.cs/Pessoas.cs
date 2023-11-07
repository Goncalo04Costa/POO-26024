using System;

namespace Person
{
    public class Pessoas
    {
        private Pessoa[] pessoasArray;

        public Pessoas(int tamanhoArray)
        {
            pessoasArray = new Pessoa[tamanhoArray];
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
