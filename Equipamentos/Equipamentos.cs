/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;

namespace Equipment
{
    public class Equipamentos
    {
        private List<Equipamento> equipamentosList; // Utilizando List<Equipamento> em vez de Equipamento[]

        public Equipamentos()
        {
            equipamentosList = new List<Equipamento>(); // Inicializando a lista vazia
        }

        public List<Equipamento> EquipamentosList
        {
            get { return equipamentosList; }
        }

        public bool AdicionarEquipamento(Equipamento equipamento)
        {
            equipamentosList.Add(equipamento); // Adicionando o equipamento à lista
            return true; // Não há um limite fixo, sempre pode adicionar
        }

        public bool RemoverEquipamento(int codigo)
        {
            Equipamento equipamentoParaRemover = equipamentosList.Find(e => e.Codigo == codigo);
            if (equipamentoParaRemover != null)
            {
                equipamentosList.Remove(equipamentoParaRemover); // Removendo o equipamento da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Equipamento> ListarEquipamentos()
        {
            return new List<Equipamento>(equipamentosList); // Retorna uma nova lista com os equipamentos
        }

        public List<Equipamento> ListarEquipamentosAvariados()
        {
            return equipamentosList.FindAll(e => e.Estado == 0); // Retorna uma lista com os equipamentos avariados
        }

        public int ContarEquipamentos()
        {
            return equipamentosList.Count; // Contando o número de equipamentos na lista
        }
    }
}
