/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */



namespace Persons
{
    public class Medicos
    {
        private Medico[] medicosArray;
        private const int MAX_MEDICOS = 2;
        private int totalMedicos;

        public Medicos()
        {
            medicosArray = new Medico[MAX_MEDICOS];
            totalMedicos = 0;
        }

        public static int MaxMedicos { get { return MAX_MEDICOS; } }

        public Medico[] MedicosArray
        {
            get { return (Medico[])medicosArray.Clone(); }
            
        }

        public int TotalMedicos
        {
            get { return totalMedicos; }
        }

        public bool AdicionarMedico(Medico medico)
        {
            if (totalMedicos < MAX_MEDICOS)
            {
                medicosArray[totalMedicos] = medico;
                totalMedicos++;
                return true; // Indica que o médico foi adicionado com sucesso
            }
            else
            {
                return false; // Indica que não foi possível adicionar o médico devido ao limite atingido
            }
        }

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
                    return true; // Indica que o médico foi removido com sucesso
                }
            }

            return false; // Indica que o médico não foi encontrado para remoção
        }


        public int ContarMedicos()
        {
            return totalMedicos;
        }
    }
}

