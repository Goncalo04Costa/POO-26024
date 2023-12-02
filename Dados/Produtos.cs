/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;
using ObjetosdeNegocio;

namespace Dados
{
    public class Produtos
    {
        private List<Produto> produtosList; // Utilizando List<Produto> em vez de Produto[]

        public Produtos()
        {
            produtosList = new List<Produto>(); // Inicializando a lista vazia
        }

        public List<Produto> ProdutosList
        {
            get { return produtosList; }
        }

        public void AdicionarProduto(Produto produto)
        {
            produtosList.Add(produto); // Adicionando o produto à lista
        }

        public bool RemoverProduto(int codigo)
        {
            Produto produtoParaRemover = produtosList.Find(p => p.Codigo == codigo);
            if (produtoParaRemover != null)
            {
                produtosList.Remove(produtoParaRemover); // Removendo o produto da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Produto> ListarProdutos()
        {
            return new List<Produto>(produtosList); // Retorna uma nova lista com os produtos
        }

        public int ContarProdutos()
        {
            return produtosList.Count; // Contando o número de produtos na lista
        }
    }
}
