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


        public void RemoverPessoa(int NIF)
        {

            for (int i = 0; i < totalPessoas; i++)
            {
                if (pessoasArray[i].Nif == NIF)
                {
                    for (int j = i; j < totalPessoas - 1; j++)
                    {
                        pessoasArray[j] = pessoasArray[j + 1];
                    }
                    pessoasArray[totalPessoas - 1] = null;
                    totalPessoas--;
                    return;
                }
            }
        }

        public int ContaPessoa()
        {
            return totalPessoas;
        }
    }

}