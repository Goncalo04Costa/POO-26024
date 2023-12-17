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
        private List<Limpeza> limpezasList; 

        public Limpezas()
        {
            limpezasList = new List<Limpeza>(); 
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
                limpezasList.Remove(produtoLimpezaParaRemover); 
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Limpeza> ListarProdutosLimpeza()
        {
            return new List<Limpeza>(limpezasList); 
        }

        public int ContarProdutoLimpeza()
        {
            return limpezasList.Count; 
        }
    }
}
