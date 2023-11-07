
namespace Person
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

        public void AdicionarMedico(Medico medico)
        {
            if (totalMedicos < MAX_MEDICOS)
            {
                medicosArray[totalMedicos] = medico;
                totalMedicos++;
            }
            else
            {
                Console.WriteLine("O limite máximo de médicos foi atingido. Não é possível adicionar mais médicos.");
            }
        }

        public void ListarMedicos()
        {
            Console.WriteLine("Lista de Médicos:");
            foreach (Medico medico in medicosArray)
            {
                if (medico != null)
                {
                    Console.WriteLine(medico.ToString());
                }
            }
        }

        // Outros métodos de gerenciamento do array de médicos podem ser adicionados aqui.

    }
}
