/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

namespace Persons
{
    /// <summary>
    /// Classe responsável por gerenciar um conjunto de médicos.
    /// </summary>
    public class Medicos
    {
        private Medico[] medicosArray; 
        private const int MAX_MEDICOS = 2; 
        private int totalMedicos;

        /// <summary>
        /// Construtor padrão da classe Medicos.
        /// Inicializa o array de médicos e o contador de médicos.
        /// </summary>
        public Medicos()
        {
            medicosArray = new Medico[MAX_MEDICOS];
            totalMedicos = 0;
        }

        /// <summary>
        /// Propriedade estática que retorna o número máximo de médicos permitidos.
        /// </summary>
        public static int MaxMedicos { get { return MAX_MEDICOS; } }

        /// <summary>
        /// Obtém uma cópia do array de médicos.
        /// </summary>
        public Medico[] MedicosArray
        {
            get { return (Medico[])medicosArray.Clone(); }
        }

        /// <summary>
        /// Obtém o total atual de médicos cadastrados.
        /// </summary>
        public int TotalMedicos
        {
            get { return totalMedicos; }
        }

        /// <summary>
        /// Adiciona um médico à lista, se houver espaço disponível.
        /// </summary>
        /// <param name="medico">O médico a ser adicionado.</param>
        /// <returns>True se o médico foi adicionado com sucesso, False caso contrário.</returns>
        public bool AdicionarMedico(Medico medico)
        {
            if (totalMedicos < MAX_MEDICOS)
            {
                medicosArray[totalMedicos] = medico;
                totalMedicos++;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Remove um médico com base no seu código.
        /// </summary>
        /// <param name="codigoMedico">O código do médico a ser removido.</param>
        /// <returns>True se o médico foi removido com sucesso, False caso contrário.</returns>
        public bool RemoverMedico(int codigoMedico)
        {
            for (int i = 0; i < totalMedicos; i++)
            {
                if (medicosArray[i].CodigoMedico == codigoMedico)
                {
                    for (int j = i; j < totalMedicos - 1; j++)
                    {
                        medicosArray[j] = medicosArray[j + 1];
                    }
                    medicosArray[totalMedicos - 1] = null;
                    totalMedicos--;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Retorna o número atual de médicos cadastrados.
        /// </summary>
        /// <returns>O total de médicos cadastrados.</returns>
        public int ContarMedicos()
        {
            return totalMedicos;
        }
    }
}
