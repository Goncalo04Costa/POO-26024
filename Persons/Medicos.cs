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
    /// Classe responsável por gerenciar um conjunto de médicos.
    /// </summary>
    public class Medicos
    {
        private List<Medico> medicosList; // Utilizando List<Medico> em vez de Medico[]

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
