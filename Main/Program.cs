using System;
using System.Net;
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
            Enfermeiros listaEnfermeiros = new Enfermeiros();
            Medicos listaMedicos = new Medicos();

            // Adicionando alguns elementos para testar
            listaUtentes.AdicionarUtente(new Utente { Nome = "Alice", Nif = 12345, Idade = 30 });
            listaUtentes.AdicionarUtente(new Utente { Nome = "Bob", Nif = 54321, Idade = 25 });

            listaMedicamentos.AdicionarMedicamento(new Medicamento { Codigo = 1, Nome = "Paracetamol", Stock = 50 });
            listaMedicamentos.AdicionarMedicamento(new Medicamento { Codigo = 2, Nome = "Aspirina", Stock = 30 });

            listaEquipamentos.AdicionarEquipamento(new Equipamento { Codigo = 101, Nome = "Computador", Estado = 1 });
            listaEquipamentos.AdicionarEquipamento(new Equipamento { Codigo = 102, Nome = "Projetor", Estado = 0 });

            listaEnfermeiros.AdicionarEnfermeiro(new Enfermeiro { CodigoEnfermeiro = 1, Condicao = "Ativo", Nome = "Maria", Apelido = "Silva", Idade = 35, Nif = 98765, Sns = 456789, Contacto = 912345678 });
            listaEnfermeiros.AdicionarEnfermeiro(new Enfermeiro { CodigoEnfermeiro = 2, Condicao = "Inativo", Nome = "João", Apelido = "Ferreira", Idade = 40, Nif = 54321, Sns = 123456, Contacto = 923456789 });

            listaMedicos.AdicionarMedico(new Medico { CodigoMedico = 1, Especialidade = "Pediatra", Nome = "António", Apelido = "Fernandes", Idade = 45, Nif = 123456789, Sns = 987654321, Contacto = 933333333 });
            listaMedicos.AdicionarMedico(new Medico { CodigoMedico = 2, Especialidade = "Cardiologista", Nome = "Sofia", Apelido = "Martins", Idade = 38, Nif = 987654321, Sns = 123456789, Contacto = 911111111 });

            // Exibindo os elementos adicionados para cada categoria
            Console.WriteLine("Utentes:");
            foreach (Utente utente in listaUtentes.ListarUtentes())
            {
                Console.WriteLine($"Nome: {utente.Nome}, NIF: {utente.Nif}, Idade: {utente.Idade}");
            }

            Console.WriteLine("\nEquipamentos:");
            foreach (Equipamento equipamento in listaEquipamentos.Listarequipamentos())
            {
                Console.WriteLine($"Código: {equipamento.Codigo}, Nome: {equipamento.Nome}, Estado: {equipamento.Estado}");
            }

            Console.WriteLine("\nEquipamentos Avariados:");
            foreach (Equipamento equipamento in listaEquipamentos.Listarequipamentosavariados())
            {
                Console.WriteLine($"Código: {equipamento.Codigo}, Nome: {equipamento.Nome}, Estado: {equipamento.Estado}");
            }

            Console.WriteLine("\nEnfermeiros:");
            foreach (Enfermeiro enfermeiro in listaEnfermeiros.ListarEnfermeiro())
            {
                Console.WriteLine($"Nome: {enfermeiro.Nome}, Código: {enfermeiro.CodigoEnfermeiro}, Condição: {enfermeiro.Condicao}");
            }

            Console.WriteLine("\nMédicos:");
            foreach (Medico medico in listaMedicos.ListarMedicos())
            {
                Console.WriteLine($"Nome: {medico.Nome}, Especialidade: {medico.Especialidade}, Código Médico: {medico.CodigoMedico}");
            }

            Console.ReadKey();
        }
    }
}
