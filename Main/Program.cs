using System;
using Equipment;
using Persons;
using Product;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias das classes
            Utentes listaUtentes = new Utentes();
            Medicamentos listaMedicamentos = new Medicamentos();
            Equipamentos listaEquipamentos = new Equipamentos();

            // Adicionando alguns elementos para testar
            listaUtentes.AdicionarUtente(new Utente { Nome = "Alice", Nif = 12345, Idade = 30 });
            listaUtentes.AdicionarUtente(new Utente { Nome = "Bob", Nif = 54321, Idade = 25 });

            listaMedicamentos.AdicionarMedicamento(new Medicamento { Codigo = 1, Nome = "Paracetamol", Stock = 50 });
            listaMedicamentos.AdicionarMedicamento(new Medicamento { Codigo = 2, Nome = "Aspirina", Stock = 30 });

            listaEquipamentos.AdicionarEquipamento(new Equipamento { Codigo = 101, Nome = "Computador", Estado = 1 });
            listaEquipamentos.AdicionarEquipamento(new Equipamento { Codigo = 102, Nome = "Projetor", Estado = 0 });

            ListarUtentes(listaUtentes);
            ListarMedicamentos(listaMedicamentos);
            //ListarEquipamentos(listaEquipamentos);

            Console.ReadKey();
        }

        static void ListarUtentes(Utentes listaUtentes)
        {
            Console.WriteLine("Lista de Utentes:");
            foreach (var utente in listaUtentes.UtentesArray)
            {
                if (utente != null)
                {
                    Console.WriteLine(utente.ToString());
                }
            }
            Console.WriteLine($"Total de Utentes: {listaUtentes.ContarUtentes()}");
            Console.WriteLine();
        }

        static void ListarMedicamentos(Medicamentos listaMedicamentos)
        {
            Console.WriteLine("Lista de Medicamentos:");
            foreach (var medicamento in listaMedicamentos.MedicamentosArray)
            {
                if (medicamento != null)
                {
                    Console.WriteLine(medicamento.ToString());
                }
            }
            Console.WriteLine($"Total de Medicamentos: {listaMedicamentos.ContaMedicamento()}");
            Console.WriteLine();
        }

       /* static void ListarEquipamentos(Equipamentos listaEquipamentos)
        {
            Console.WriteLine("Lista de Equipamentos:");
            foreach (var equipamento in listaEquipamentos.EquipamentosArray)
            {
                if (equipamento != null)
                {
                    Console.WriteLine(equipamento.ToString());
                }
            }
            Console.WriteLine($"Total de Equipamentos: {listaEquipamentos.TotaldeEquipamentos()}");
            Console.WriteLine();
        }*/
    }
}
