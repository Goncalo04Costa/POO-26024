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
    public class Limpezas
    {
        private static List<Limpeza> limpezasList; 

        static  Limpezas()
        {
            limpezasList = new List<Limpeza>();
        }
        
        public Limpezas()
        {
           
        }

        public List<Limpeza> LimpezasList
        {
            get { return limpezasList; }
        }


        /// <summary>
        /// Método estático para inserir um novo produto de limpeza na lista estática compartilhada.
        /// </summary>
        /// <param name="novofunc">O produto de limpeza a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereProdLimpezaLista(Limpeza novoProdLimpeza)
        {
            Limpeza limpezaexistente = limpezasList.Find(m => m.Codigo == novoProdLimpeza.Codigo);

            if (limpezaexistente != null)
            {
                limpezaexistente.Stock++;
            }
            else
            {
                novoProdLimpeza.Stock = 1;
                limpezasList.Add(novoProdLimpeza);
            }

            return true;
        }

        /// <summary>
        /// Metodo estatico para remover um produto de limpeza
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool RemoverProdLimpeza(int codigo)
        {
            Limpeza limpezaARemover = limpezasList.Find(m => m.Codigo == codigo);
            if (limpezaARemover != null)
            {

                limpezaARemover.Stock--;


                if (limpezaARemover.Stock == 0)
                {
                    limpezasList.Remove(limpezaARemover);
                }

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
