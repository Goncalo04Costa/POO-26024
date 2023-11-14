using System;
using Equipment;
using Persons;

namespace ExemploRemoverEquipamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipamentos equipamentos = new Equipamentos();
            Auxiliares auxiliares = new Auxiliares();


            Auxiliar auxiliar1 = new Auxiliar(101, "Boa condição");
            Auxiliar auxiliar2 = new Auxiliar(102, "Condição média");
            Auxiliar auxiliar3 = new Auxiliar(103, "Condição excelente");

            // Adicionando os auxiliares à coleção
            auxiliares.AdicionarAuxiliar(auxiliar1);
            auxiliares.AdicionarAuxiliar(auxiliar2);
            auxiliares.AdicionarAuxiliar(auxiliar3);


            // Criando alguns equipamentos
            Equipamento equipamento1 = new Equipamento(1, "Equipamento 1", "Descrição do Equipamento 1", 100, 1);
            Equipamento equipamento2 = new Equipamento(2, "Equipamento 2", "Descrição do Equipamento 2", 80, 0);
            Equipamento equipamento3 = new Equipamento(3, "Equipamento 3", "Descrição do Equipamento 3", 120, 1);

            // Adicionando os equipamentos à coleção
            equipamentos.NewEquipamento(equipamento1);
            equipamentos.NewEquipamento(equipamento2);
            equipamentos.NewEquipamento(equipamento3);

            // Chamando a função para listar os equipamentos antes da remoção
            ListarEquipamentos(equipamentos);

            // Removendo um equipamento específico (nesse caso, o equipamento com código 2)
            equipamentos.RemoverEquipamento(2);

            Console.WriteLine("\nEquipamento removido.");

            // Chamando a função para listar os equipamentos após a remoção
            ListarEquipamentos(equipamentos);

            // Chamando a função para listar os auxiliares
            ListarAuxiliares(auxiliares);
        }

        public static void ListarEquipamentos(Equipamentos equipamentos)
        {
            Equipamento[] listaEquipamentos = equipamentos.EquipamentoosArray;
            int totalEquipamentos = equipamentos.TotaldeEquipamentos;

            if (totalEquipamentos == 0)
            {
                Console.WriteLine("Não há equipamentos na coleção.");
                return;
            }

            Console.WriteLine("Lista de Equipamentos:");
            for (int i = 0; i < totalEquipamentos; i++)
            {
                Console.WriteLine($"Equipamento {i + 1}:");
                Console.WriteLine($"Código: {listaEquipamentos[i].Codigo}");
                Console.WriteLine($"Nome: {listaEquipamentos[i].Nome}");
                Console.WriteLine($"Descrição: {listaEquipamentos[i].Descricao}");
                Console.WriteLine($"Carga: {listaEquipamentos[i].Carga}");
                Console.WriteLine($"Estado: {listaEquipamentos[i].Estado}");
                Console.WriteLine();
            }
        }

        public static void ListarAuxiliares(Auxiliares auxiliares)
        {
            Auxiliar[] listaAuxiliares = auxiliares.AuxiliaresArray;
            int totalAuxiliares = auxiliares.TotalAuxiliares;

            if (totalAuxiliares == 0)
            {
                Console.WriteLine("Não há auxiliares na coleção.");
                return;
            }

            Console.WriteLine("Lista de Auxiliares:");
            for (int i = 0; i < totalAuxiliares; i++)
            {
                Console.WriteLine($"Auxiliar {i + 1}:");
                Console.WriteLine($"Nome: {listaAuxiliares[i].Nome}");
                // Incluir outras informações do auxiliar, se necessário
                Console.WriteLine();
            }
        }
    }
}
