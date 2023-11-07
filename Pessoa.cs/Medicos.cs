
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

        public static int MaxMedicos { get { return MAX_MEDICOS; } }

        public Medico[] MedicosArray
        {
            get { return (Medico[])medicosArray.Clone(); }
            set { } // EVITAR!
        }

        public int TotalMedicos
        {
            get { return totalMedicos; }
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


        public void ListarMedicosPorEspecialidade(string especialidade)
        {
            Console.WriteLine($"Lista de Médicos com a Especialidade {especialidade}:");
            foreach (Medico medico in medicosArray)
            {
                if (medico != null && medico.Especialidade == especialidade)
                {
                    Console.WriteLine(medico.ToString());
                }
            }
        }

    }
}
