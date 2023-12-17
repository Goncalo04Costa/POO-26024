/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using Excecao;
using ObjetosdeNegocio;

namespace Dados
{
    /// <summary>
    /// Classe responsável por gerenciar um conjunto de Utentes.
    /// </summary>
    public class Utentes
    {
        private static List<Utente> utentesList; 

        static Utentes()
        {
            utentesList = new List<Utente>(); 
        }

        /// <summary>
        /// Método estático para inserir um novo utente na lista estática compartilhada.
        /// </summary>
        /// <param name="novoutente">O utente a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereUtenteLista(Utente novoutente)
        {


            foreach (Utente aux in utentesList)
            {
                if (aux.Equals(novoutente))
                {
                    throw new UtenteException("Já existe este utente na lista.");
                }
            }

            utentesList.Add(novoutente);
            return true;

        }

        /// <summary>
        /// Verifica se um utente com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="Nif">O NIF a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public bool ExisteUtente(int Nif)
        {
            return utentesList.Any(a => a.Nif == Nif);
        }


        /// <summary>
        /// Remove um utente com base no seu código.
        /// </summary>
        /// <param name="Nif">O NIF do utente a ser removido.</param>
        /// <returns>True se o utente foi removido com sucesso, False caso contrário.</returns>
        public bool RemoveUtente(int Nif)
        {
            Utente utente = utentesList.Find(a => a.Nif == Nif);
            if (utente != null)
            {
                utentesList.Remove(utente);
                return true;
            }
            return false;
        }



        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LerUtente(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    utentesList = (List<Utente>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroUtenteException("Erro ao ler o ficheiro de utentes: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GravarUtentes(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, utentesList);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiroUtenteException e)
            {
                throw new EscritaFicheiroUtenteException("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }


        public Utente  EncontraUtente(int nif)
        {
            foreach (Utente u in utentesList)
            {
                if (u.Nif == nif)
                {
                    return u;
                }
            }
            return null;
        }

        public bool DarAltaUtente(int nif)
        {
            Utente utenteParaDarAlta = EncontraUtente(nif);
            if (utenteParaDarAlta != null)
            {
                utenteParaDarAlta.Estado = 2;
                utentesList.Remove(utenteParaDarAlta);
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Utente> ObterUtentesSemContactoFamiliar()
        {
            List<Utente> utentesSemContactoFamiliar = new List<Utente>();

            foreach (Utente utente in utentesList)
            {
                if (utente.Contactofamiliar == 0)
                {
                    utentesSemContactoFamiliar.Add(utente);
                }
            }

            return utentesSemContactoFamiliar;
        }


        public List<Utente> ListarUtentes()
        {
            return new List<Utente>(utentesList); 
        }

        public int ContarUtentes()
        {
            return utentesList.Count; 
        }

      

    }
}
