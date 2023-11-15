/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace Equipment
{
     public class Equipamentos
    {

        private Equipamento[] equipamentosArray;
        private const int MAX_equipamentos = 40;
        private int totalequipamentos;

        /// <summary>
        /// Construtor padrão que inicializa um array de equipamentos e define o total de equipamentos como 0.
        /// </summary>
        public Equipamentos()
        {
            equipamentosArray = new Equipamento[MAX_equipamentos];
            totalequipamentos = 0;
        }

        /// <summary>
        /// Obtém o número máximo de equipamentos permitidos.
        /// </summary>
        public static int MaxEquipamentos { get { return MAX_equipamentos; } }

        /// <summary>
        /// Obtém uma cópia do array de equipamentos.
        /// </summary>
        public Equipamento[] EquipamentoosArray
        {
            get { return (Equipamento[])equipamentosArray.Clone(); }
            set { }
        }

        /// <summary>
        /// Obtém o total atual de equipamentos no array.
        /// </summary>
        public int TotaldeEquipamentos
        {
            get { return totalequipamentos; }
        }

        #region Outros Métodos

        /// <summary>
        /// Adiciona um equipamento ao  array, desde que o limite máximo não tenha sido atingido.
        /// </summary>
        /// <param name="equipamento">O  equipamento a ser adicionado.</param>
        public bool AdicionarEquipamento(Equipamento equipamento)
        {
            if (totalequipamentos < MAX_equipamentos)
            {
                equipamentosArray[totalequipamentos] = equipamento;
                totalequipamentos++;
                return true; // Indica que o equipamento foi adicionado com sucesso
            }
            else
            {
                return false; // Indica que não foi possível adicionar o equipamento devido ao limite atingido
            }
        }


        /// <summary>
        /// Remove um equipamento com base no codigo.
        /// </summary>
        /// <param name="codigo">O codigo do equipamento a ser removido.</param>
        public bool RemoverEquipamento(int codigo)
        {
            for (int i = 0; i < totalequipamentos; i++)
            {
                if (equipamentosArray[i].Codigo == codigo)
                {
                    for (int j = i; j < totalequipamentos - 1; j++)
                    {
                        equipamentosArray[j] = equipamentosArray[j + 1];
                    }
                    equipamentosArray[totalequipamentos - 1] = null;
                    totalequipamentos--;
                    return true; 
                }
            }

            return false; 
        }


        /// <summary>
        /// Retorna o número total de equipamento no array.
        /// </summary>
        public int Contaequipamento()
        {
            return totalequipamentos; 
        }

        #endregion
    }
}