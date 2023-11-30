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

        public bool ExisteUtente(int nif)
        {
            return utentesList.Any(u => u.Nif == nif);
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

        public bool DarAltaUtente(int nif)
        {
            Utente utenteParaDarAlta = utentesList.Find(u => u.Nif == nif);
            if (utenteParaDarAlta != null)
            {
                utenteParaDarAlta.Estado = 2; // Altera o estado para 2 (alta da UCCI)
                utentesList.Remove(utenteParaDarAlta); // Remove o utente da lista
                return true;
            }
            else
            {
                return false; // Utente com o NIF especificado não encontrado
            }
        }

        public Utente ObterUtentePorNIF(int nif)
        {
            return utentesList.Find(u => u.Nif == nif);
        }


        public bool AtualizarInformacoesUtente(Utente utente)
        {
            int index = utentesList.FindIndex(u => u.Nif == utente.Nif);
            if (index != -1)
            {
                utentesList[index] = utente;
                return true;
            }
            return false; // Utente não encontrado
        }


        public double CalcularMediaIdadeUtentes()
        {
            if (utentesList.Count == 0) return 0;

            return utentesList.Average(u => u.Idade);
        }

        public Dictionary<int, int> ContarUtentesPorEstado()
        {
            return utentesList.GroupBy(u => u.Estado)
                              .ToDictionary(g => g.Key, g => g.Count());
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
