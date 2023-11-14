using Product;
using Persons;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar instância de Utentes
            Utentes utentes = new Utentes();

            // Adicionar utentes
            Utente utente1 = new Utente { Nome = "João", Idade = 30, Nif = 12345 };
            Utente utente2 = new Utente { Nome = "Maria", Idade = 25, Nif = 67890 };
            Utente utente3 = new Utente { Nome = "Pedro", Idade = 35, Nif = 13579 };

            utentes.AdicionarUtente(utente1);
            utentes.AdicionarUtente(utente2);
            utentes.AdicionarUtente(utente3);

            // Listar todos os utentes
            Console.WriteLine("Lista de todos os utentes:");
            utentes.ListarTodosUtentes();

            // Remover um utente pelo NIF
            int nifToRemove = 67890;
            utentes.RemoverUtente(nifToRemove);

            Console.WriteLine("\nApós remover um utente:");
            utentes.ListarTodosUtentes();

            // Listar utentes por idade
            int idadeParaListar = 30;
            Console.WriteLine($"\nLista de utentes com mais de {idadeParaListar} anos:");
            utentes.ListarUtentesPorIdade(idadeParaListar);

            // Adicionar mais utentes
            Utente utente4 = new Utente { Nome = "Ana", Idade = 40, Nif = 24680 };
            utentes.AdicionarUtente(utente4);

            Console.WriteLine("\nApós adicionar um novo utente:");
            utentes.ListarTodosUtentes();

            // Mais operações ou testes podem ser adicionados aqui
        }
    }
}
