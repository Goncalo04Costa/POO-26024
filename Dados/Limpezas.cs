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
    public class Limpezas
    {
        private List<Limpeza> limpezasList; // Utilizando List<Limpeza> em vez de Limpeza[]

        public Limpezas()
        {
            limpezasList = new List<Limpeza>(); // Inicializando a lista vazia
        }

        public List<Limpeza> LimpezasList
        {
            get { return limpezasList; }
        }

        public bool AdicionarProdutoLimpeza(Limpeza limpeza)
        {
          limpezasList.Add(limpeza);
            return true;
        }

        public bool RemoverProdutoLimpeza(int codigo)
        {
            Limpeza produtoLimpezaParaRemover = limpezasList.Find(p => p.Codigo == codigo);
            if (produtoLimpezaParaRemover != null)
            {
                limpezasList.Remove(produtoLimpezaParaRemover); // Removendo o produto de limpeza da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Limpeza> ListarProdutosLimpeza()
        {
            return new List<Limpeza>(limpezasList); // Retorna uma nova lista com os produtos de limpeza
        }

        public int ContarProdutoLimpeza()
        {
            return limpezasList.Count; // Contando o número de produtos de limpeza na lista
        }
    }
}
