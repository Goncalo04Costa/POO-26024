/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;
using ObjetosdeNegocio;

namespace Dados
{
    /// <summary>
    /// Classe que representa uma coleção dinâmica de Medicamentos.
    /// </summary>
    public class Medicamentos
    {
        private static List<Medicamento> medicamentosList; 

        static Medicamentos()
        {
            medicamentosList = new List<Medicamento>(); 
        }

        public Medicamentos()
        {

        }
        public List<Medicamento> MedicamentosList
        {
            get { return medicamentosList; }
        }

        public void AdicionarMedicamento(Medicamento medicamento)
        {
            medicamentosList.Add(medicamento); 
        }

        public bool RemoverMedicamento(int codigo)
        {
            Medicamento medicamentoParaRemover = medicamentosList.Find(m => m.Codigo == codigo);
            if (medicamentoParaRemover != null)
            {
                medicamentosList.Remove(medicamentoParaRemover); // Removendo o medicamento da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Medicamento> ListarMedicamentos()
        {
            return new List<Medicamento>(medicamentosList); // Retorna uma nova lista com os medicamentos
        }

        public int ContarMedicamentos()
        {
            return medicamentosList.Count; // Contando o número de medicamentos na lista
        }
    }
}
