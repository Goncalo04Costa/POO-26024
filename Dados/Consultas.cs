using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ObjetosdeNegocio;
using Excecao;

namespace Dados
{
    public class Consultas
    {
        private static List<Consulta> ConsultasList; 
        private static Utentes listaUtentes; 
      
        static Consultas()
        {
            ConsultasList = new List<Consulta>(); 
        }

       
        public Consultas()
        {

        }

  
        public List<Consulta> Consultaslist
        {
            get { return ConsultasList; }
        }


        public List<Consulta> ListaConsultas()
        {
            return new List<Consulta>(ConsultasList); 
        }

       
        public int ContaConsultas()
        {
            return ConsultasList.Count; 
        }

        /// <summary>
        /// Método estático para inserir uma nova consuulta na lista estática compartilhada.
        /// </summary>
        /// <param name="novoAuxiliar">Consulta a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereConsultaLista(Consulta novoConsulta)
        {


            foreach (Consulta aux in ConsultasList)
            {
                if (aux.Equals(novoConsulta))
                {
                    throw new AuxiliarException("Já existe esta consulta na lista.");
                }
            }

            ConsultasList.Add(novoConsulta);
            return true;

        }

        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LerConsultas(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    ConsultasList = (List<Consulta>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroConsultaException("Erro ao ler o ficheiro de consultas: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GravarConsultas(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, ConsultasList);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiroConsultasException e)
            {
                throw new EscritaFicheiroConsultasException("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }

        /// <summary>
        /// Verificar os clientes que precisam de transporte
        /// </summary>
        /// <param name="snsConsulta"></param>
        /// <param name="listaDeUtentes"></param>
        /// <returns></returns>
        public bool VerificarContactoFamiliarPorSNS(int snsConsulta, Utentes listaDeUtentes)
        {
            Utente utenteEncontrado = listaDeUtentes.UtentesList.Find(u => u.Nif == snsConsulta);

            if (utenteEncontrado != null)
            {
                return utenteEncontrado.ContactoFamiliarProperty == 0;
            }
            return false;
        }
    }
}
