/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;

namespace Persons
{
    /// <summary>
    /// Classe responsável por gerenciar um conjunto de Utentes.
    /// </summary>
    public class Utentes
    {
        private List<Utente> utentesList; // Utilizando List<Utente> em vez de Utente[]

        public Utentes()
        {
            utentesList = new List<Utente>(); // Inicializando a lista vazia
        }

        public List<Utente> UtentesList
        {
            get { return utentesList; }
        }

        public bool AdicionarUtente(Utente utente)
        {
            utentesList.Add(utente); // Adicionando o utente à lista
            return true; // Não há um limite fixo, sempre pode adicionar
        }

        public bool RemoverUtente(int nif)
        {
            Utente utenteParaRemover = utentesList.Find(u => u.Nif == nif);
            if (utenteParaRemover != null)
            {
                utentesList.Remove(utenteParaRemover); // Removendo o utente da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Utente> ListarUtentes()
        {
            return new List<Utente>(utentesList); // Retorna uma nova lista com os utentes
        }

        public int ContarUtentes()
        {
            return utentesList.Count; // Contando o número de utentes na lista
        }
    }
}
