/*
 * Gonçalo Cardoso Ferreira da Costa
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */
namespace Product
{
    public class Medicamentos
    {
        private Medicamento[] medicamentosArray;
        private const int MAX_Medicamentos = 320;
        private int totalmedicamentos;

        /// <summary>
        /// Construtor padrão que inicializa um array de medicamentos e define o total de medicamentos como 0.
        /// </summary>
        public Medicamentos()
        {
            medicamentosArray = new Medicamento[MAX_Medicamentos];
            totalmedicamentos = 0;
        }

        /// <summary>
        /// Obtém o número máximo de medicamentos permitidos.
        /// </summary>
        public static int MaxMedicamentos { get { return MAX_Medicamentos; } }

        /// <summary>
        /// Obtém uma cópia do array de medicamentos.
        /// </summary>
        public Medicamento[] MedicamentosArray
        {
            get { return (Medicamento[])medicamentosArray.Clone(); }
            set { } 
        }

        /// <summary>
        /// Obtém o total atual de medicamentos no array.
        /// </summary>
        public int TotaldeMedicamentos
        {
            get { return totalmedicamentos; }
        }

        #region Outros Métodos

        /// <summary>
        /// Adiciona um medicamento ao  array, desde que o limite máximo não tenha sido atingido.
        /// </summary>
        /// <param name="medicamento">O  medicamento a ser adicionado.</param>
        public void NewMedicamento(Medicamento medicamento)
        {
            if (totalmedicamentos < MAX_Medicamentos)
            {
                medicamentosArray[totalmedicamentos] = medicamento;
                totalmedicamentos++;
            }
            else
            {
                Console.WriteLine("O limite máximo de medicamento foi atingido. Não é possível adicionar mais medicamento.");
            }
        }


        /// <summary>
        /// Remove um medicamento com base no codigo.
        /// </summary>
        /// <param name="codigo">O codigo do medicamento a ser removido.</param>
        public void RemoverMedicamento(int codigo)
        {
            for (int i = 0; i < totalmedicamentos; i++)
            {
                if (medicamentosArray[i].Codigo == codigo)
                {
                    for (int j = i; j < totalmedicamentos - 1; j++)
                    {
                        medicamentosArray[j] = medicamentosArray[j + 1];
                    }
                    medicamentosArray[totalmedicamentos - 1] = null;
                    totalmedicamentos--;
                    return;
                }
            }
        }

        /// <summary>
        /// Retorna o número total de medicamentos no array.
        /// </summary>
        public int ContaMedicamento()
        {
            return totalmedicamentos; ;
        }

        #endregion
    }
}
