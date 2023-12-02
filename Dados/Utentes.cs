/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using ObjetosdeNegocio;

namespace Dados
{
    /// <summary>
    /// Classe responsável por gerenciar um conjunto de Utentes.
    /// </summary>
    public class Utentes
    {
        private List<Utente> utentesList; 

        public Utentes()
        {
            utentesList = new List<Utente>(); 
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
            utentesList.Add(utente); 
            return true; 
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

        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LeUtentes()
        {
            if (!(File.Exists("Utentes.bin"))) return false;
            Stream s = File.Open("Utentes.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            utentesList = (List<Utente>)b.Deserialize(s);
            s.Close();
            return true;
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaUtente()
        {
            if (!(File.Exists("Utentes.bin"))) return false;
            Stream s = File.Open("Utentes.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, utentesList);
            s.Close();
            return true;
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
