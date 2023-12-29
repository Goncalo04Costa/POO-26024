/*
*	<copyright file="Utentes" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 30/11/2023 18:17:15</date>
*	<description></description>
**/


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
        /// <param name="Sns">O SNS a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public static bool ExisteUtente(int Sns)
        {
            return utentesList.Any(a => a.Sns == Sns);
        }


        /// <summary>
        /// Remove um utente com base no seu código.
        /// </summary>
        /// <param name="Nif">O NIF do utente a ser removido.</param>
        /// <returns>True se o utente foi removido com sucesso, False caso contrário.</returns>
        public static bool RemoveUtente(int Nif)
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
        public static bool LerUtente(string nomeFicheiro)
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
                throw new LeituraFicheiroException("Erro ao ler o ficheiro de utentes: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GravarUtentes(string nomeFicheiro)
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
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }

        /// <summary>
        /// Remove todas os utentes da lista de utentes.
        /// </summary>
        /// <returns></returns>
        public static bool RemoverUtentes()
        {
            utentesList.Clear();
            return true;
        }


        /// <summary>
        /// Procura e devolve um utente na lista com base no (NIF).
        /// </summary>
        /// <param name="nif">O número de identificação fiscal a ser procurado.</param>
        /// <returns>O utente correspondente ao NIF fornecido ou null se não for encontrado.</returns>
        public static Utente EncontraUtente(int nif)
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



        /// <summary>
        /// Metodo para dar alta a um utente
        /// </summary>
        /// <param name="nif">O nif a ser procurado</param>
        /// <returns></returns>
        public static bool DarAltaUtente(int nif)
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

       


        /// <summary>
        /// Mostra todos os utentes sem contacto familiar
        /// </summary>
        /// <returns>Lista de utentes sem contacto familiar</returns>
        public  List<Utente> ObterUtentesSemContactoFamiliar()
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

        /// <summary>
        /// Retorna a lista de utentes.
        /// </summary>
        /// <returns>Uma lista com os utentes.</returns>
        public List<Utente> ListarUtentes()
        {
            return new List<Utente>(utentesList);
        }

        /// <summary>
        /// Conta o número total de utentes na lista.
        /// </summary>
        /// <returns>O número total de utentes.</returns>
        public int ContarUtentes()
        {
            return utentesList.Count;
        }

        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de enfermeiros.
        /// </summary>
        /// <returns>Uma lista contendo todos os enfermeiros.</returns>
        public static List<Utente> EnviarTodosUtentes()
        {
            return utentesList.ToList();
        }


        /// <summary>
        /// apresentar as utentes  por data entrada
        /// </summary>
        public void OrdenarUtentespordata()
        {
            utentesList.Sort();
        }


    }
}
