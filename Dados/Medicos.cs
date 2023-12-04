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
    /// Classe responsável por gerir um conjunto de médicos.
    /// </summary>
    public class Medicos
    {
        private static List<Medico> medicosList; 

        public Medicos()
        {
            medicosList = new List<Medico>(); // Inicializando a lista vazia
        }

        public List<Medico> MedicosList
        {
            get { return medicosList; }
        }

        public bool AdicionarMedico(Medico medico)
        {
            medicosList.Add(medico); // Adicionando o médico à lista
            return true; // Não há um limite fixo, sempre pode adicionar
        }

        public bool RemoverMedico(int codigoMedico)
        {
            Medico medicoParaRemover = medicosList.Find(m => m.CodigoMedico == codigoMedico);
            if (medicoParaRemover != null)
            {
                medicosList.Remove(medicoParaRemover); // Removendo o médico da lista
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
        public bool LeMedicos()
        {
            if (!(File.Exists("Medicos.bin"))) return false;
            Stream s = File.Open("Medicos.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            medicosList = (List<Medico>)b.Deserialize(s);
            s.Close();
            return true;
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaMedicos()
        {
            if (!(File.Exists("Medicos.bin"))) return false;
            Stream s = File.Open("Medicos.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, medicosList);
            s.Close();
            return true;
        }

        public List<Medico> ListarMedicos()
        {
            return new List<Medico>(medicosList); // Retorna uma nova lista com os médicos
        }

        public int ContarMedicos()
        {
            return medicosList.Count; // Contando o número de médicos na lista
        }
    }
}
