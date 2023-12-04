/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;
using Excecao;
using ObjetosdeNegocio;

namespace Dados
{
    public class Produtos
    {
        private static List<Produto> produtosList; 

        static Produtos()
        {
            produtosList = new List<Produto>(); 
        }

        public Produtos()
        {

        }


        /// <summary>
        /// Método estático para inserir um novo produto na lista estática compartilhada.
        /// </summary>
        /// <param name="novop">O produto a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereProdutoLista(Produto novop)
        {


            foreach (Produto aux in produtosList)
            {
                if (aux.Equals(novop))
                {
                    throw new ProdutoException("Já existe este produto na lista.");
                }
            }

            produtosList.Add(novop);
            return true;

        }

        /// <summary>
        /// Verifica se um produto com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="codigop">O código do produto a ser verificado.</param>
        /// <returns>True se o produto existir na lista, False caso contrário.</returns>
        public bool ExisteFuncionario(int codigop)
        {
            return produtosList.Any(a => a.Codigo == codigop);
        }


        /// <summary>
        /// Remove um produto com base no seu código.
        /// </summary>
        /// <param name="cod">O código do produto a ser removido.</param>
        /// <returns>True se o funcionario foi removido com sucesso, False caso contrário.</returns>
        public bool RemoveProd(int cod)
        {
            Produto produto = produtosList.Find(a => a.Codigo == cod);
            if (produto != null)
            {
                produtosList.Remove(produto);
                return true;
            }
            return false;
        }


        public List<Produto> ListarProdutos()
        {
            return new List<Produto>(produtosList); 
        }

        public int ContarProdutos()
        {
            return produtosList.Count; 
        }
    }
}
