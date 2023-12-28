using System;
using ObjetosdeNegocio;
using Dados;
using Excecao;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using RegrasdeNegocio;

namespace Main
{
    class IO
    {
        static void Main(string[] args)
        {
            Auxiliar auxiliar1 = new Auxiliar(234, "21/11/2022", "Copa", 123456789, 1001, "Funcional", "Jose", "Pedro", 30, 123456789, 924070650);
            Auxiliar auxiliar2 = new Auxiliar(124, "12/01/2021", "Copa", 987654321, 0110, "Funcional", "Maria", "Pedrosa", 23, 98765431, 932120650);
            try
            {
                RN regrasNegocio = new RN();

                bool inserido1 = regrasNegocio.InsereAuxiliar(auxiliar1);
                bool inserido2 = regrasNegocio.InsereAuxiliar(auxiliar2);

                if (inserido1 && inserido2)
                {
                    Console.WriteLine("Auxiliares inseridos com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível inserir todos os auxiliares.");
                }

                List<Auxiliar> listaAuxiliares = new List<Auxiliar>(); // Defina a lista para evitar erros de compilação

                // Adicione o código para obter a lista de auxiliares
                // regrasNegocio.ObterListaAuxiliares() ou regrasNegocio.EnviarTodosAuxiliares()

                Console.WriteLine("\nLista de Auxiliares:");
                foreach (var auxiliar in listaAuxiliares)
                {
                    Console.WriteLine($"Nome: {auxiliar.Nome}, Idade: {auxiliar.Idade}, Cargo: {auxiliar.Cargo}");
                }

                string nomeArquivo = "auxiliares.dat"; // Nome do arquivo a ser gravado
                bool sucessoGravacao = RN.GravarFicheiroAuxiliares(nomeArquivo); // Usar RN para chamar método estático

                if (sucessoGravacao)
                {
                    Console.WriteLine("Informações dos auxiliares gravadas com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível gravar as informações dos auxiliares.");
                }
            }
            catch (AuxiliarException ex)
            {
                Console.WriteLine($"Erro ao inserir o auxiliar: {ex.Message}");
            }
            

            string nomeArquivo = "auxiliares.dat";
            bool sucessoLeitura = false;

            try
            {
                sucessoLeitura = RN.LerFicheiroAuxiliares(nomeArquivo);

                if (sucessoLeitura)
                {
                    List<Auxiliar> listaAuxiliaresLidos = Funcionarios.EnviarTodosAuxiliares();

                    Console.WriteLine("\nLista de Auxiliares Lidos do Arquivo:");
                    foreach (var auxiliar in listaAuxiliaresLidos)
                    {
                        Console.WriteLine($"Nome: {auxiliar.Nome}, Idade: {auxiliar.Idade}, Cargo: {auxiliar.Cargo}");
                    }
                }
                else
                {
                    Console.WriteLine("Não foi possível ler as informações dos auxiliares do arquivo.");
                }
            }
            catch (LeituraFicheiroException ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo de auxiliares: {ex.Message}");
            }
        }
    }
}
