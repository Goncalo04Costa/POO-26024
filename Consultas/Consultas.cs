/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Consultas;
using Persons; // Importante incluir o namespace Persons para ter acesso às classes de Utentes e Utente

namespace Con
{
    public class Consultas
    {
        private List<Consulta> ConsultasList;
        private Utentes listaUtentes; // Adicionando a lista de Utentes como atributo

        public Consultas(Utentes utentes)
        {
            ConsultasList = new List<Consulta>(); // Inicializando a lista vazia
            listaUtentes = utentes; // Recebendo a lista de Utentes ao criar Consultas
        }

        public List<Consulta> Consultaslist
        {
            get { return ConsultasList; }
        }

        public bool AdicionarConsulta(Consulta consulta)
        {
            ConsultasList.Add(consulta); // Adicionando a consulta à lista
            return true; // Não há um limite fixo, sempre pode adicionar
        }

        public bool RemoveConsulta(int codigo)
        {
            Consulta consultaremover = ConsultasList.Find(c => c.Consultaid == codigo);
            if (consultaremover != null)
            {
                ConsultasList.Remove(consultaremover); // Removendo a consulta da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Consulta> ListaConsultas()
        {
            return new List<Consulta>(ConsultasList); // Retorna uma nova lista de consultas
        }

        public int ContaConsultas()
        {
            return ConsultasList.Count; // Contando o número de consultas na lista
        }



        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LeConsultas()
        {
            if (!(File.Exists("Consultas.bin"))) return false;
            Stream s = File.Open("Consultas.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            ConsultasList = (List<Consulta>)b.Deserialize(s);
            s.Close();
            return true;
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaConsultas()
        {
            if (!(File.Exists("Consultas.bin"))) return false;
            Stream s = File.Open("Consultas.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, ConsultasList);
            s.Close();
            return true;
        }


        /*
         *public bool GuardaConsultas()
{
    try
    {
        Stream s = File.Open("Consultas.bin", FileMode.Create, FileAccess.Write);
        BinaryFormatter b = new BinaryFormatter();
        b.Serialize(s, ConsultasList);
        s.Close();
        return true;
    }
    catch (Exception ex)
    {
        // 
        Console.WriteLine("Erro: " + ex.Message);
        return false;
    } 
         */
        /// <summary>
        /// Metodo que verifica os utentes que não tem acompanahamento para consulta
        /// </summary>
        /// <param name="snsConsulta"></param>
        /// <param name="listaDeUtentes"></param>
        /// <returns></returns>
        public bool VerificarContactoFamiliarPorSNS(int snsConsulta, Utentes listaDeUtentes)
        {
            Utente utenteEncontrado = listaDeUtentes.UtentesList.Find(u => u.Nif == snsConsulta);

            if (utenteEncontrado != null)
            {
                if (utenteEncontrado.ContactoFamiliarProperty == 0)
                {
                 return true; 
                }
                else
                {
                 return false; 
                }
            }
            else
            {
                 return false; 
            }
        }
    }
}
