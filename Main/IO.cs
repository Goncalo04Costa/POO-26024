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
            try
            {
                // Código para inserir auxiliares e manipular seus dados
                Auxiliar auxiliar1 = new Auxiliar(234, "21/11/2022", "Copa", 123456789, 1001, "Funcional", "Jose", "Pedro", 30, 123456789, 924070650);
                Auxiliar auxiliar2 = new Auxiliar(124, "12/01/2021", "Copa", 987654321, 0110, "Funcional", "Maria", "Pedrosa", 23, 98765431, 932120650);
                Auxiliar auxiliar3 = new Auxiliar(345, "29-11-2023", "Copa", 823738273, 8912, "Funcional", "Pedro", "Malheiro", 39, 128389, 232313);

                RN regrasNegocio = new RN();

                bool inserido1 = regrasNegocio.InsereAuxiliar(auxiliar1);
                bool inserido2 = regrasNegocio.InsereAuxiliar(auxiliar2);
                bool inserido3 = regrasNegocio.InsereAuxiliar(auxiliar3);

                if (inserido1 && inserido2 && inserido3)
                {
                    Console.WriteLine("Auxiliares inseridos com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível inserir todos os auxiliares.");
                }


                // Manipulação e gravação de auxiliares em ficheiro
                List<Auxiliar> listaAuxiliares = Funcionarios.EnviarTodosAuxiliares();

                Console.WriteLine("\nLista de Auxiliares:");
                foreach (var auxiliar in listaAuxiliares)
                {
                    Console.WriteLine($"Nome: {auxiliar.Nome}, Idade: {auxiliar.Idade}, Cargo: {auxiliar.Cargo}");
                }

                string filename = "auxiliares.dat";
                bool sucessoGravacaoAuxiliares = RN.GravarFicheiroAuxiliares(filename);

                if (sucessoGravacaoAuxiliares)
                {
                    Console.WriteLine("Informações dos auxiliares gravadas com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível gravar as informações dos auxiliares.");
                }


                string nomedeficheiro = "auxiliares.dat";
                bool sucessosLeitura = false;

                try
                {
                    sucessosLeitura = RN.LerFicheiroAuxiliares(nomedeficheiro);

                    if (sucessosLeitura)
                    {
                        List<Auxiliar> listaAuxiliaresLidos = Funcionarios.EnviarTodosAuxiliares();

                        Console.WriteLine("\nLista de Auxiliares Lidos do Ficheiro:");
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





                // Consultas
                Consulta consulta1 = new Consulta(1, new DateTime(2023, 12, 21), 123456789, 987654321, "Hospital Porto", 124);
                Consulta consulta2 = new Consulta(1, new DateTime(2023, 12, 29), 1121313, 244224244, "Hospital  Coimbra", 220);


                bool inseridaConsulta1 = regrasNegocio.NovaConsulta(consulta1);
                bool inseridaConsulta2 = regrasNegocio.NovaConsulta(consulta2);

                if (inseridaConsulta1 && inseridaConsulta2)
                {
                    Console.WriteLine("Consultas inseridos com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível inserir todos as consultas.");
                }

                List<Consulta> consultas = Consultas.EnviarCOnsultas();
                Console.WriteLine("\nLista de Consultas:");
                foreach (var consulta in consultas)
                {
                    Console.WriteLine($"Data: {consulta.Data}, Utente: {consulta.SNSutente}, Local: {consulta.Hospital}");
                }

                // Código para inserir utentes e manipular seus dados
                Utente utente1 = new Utente(924070650, new DateTime(2023, 2, 20), "Estavel", 1, "Joao", "Ferreira", 65, 123456789, 1001);
                Utente utente2 = new Utente(923444444, new DateTime(2021, 12, 20), "Estavel", 0, "Joana", "Costa", 35, 987654321, 0110);

                bool inseridoUtente1 = regrasNegocio.NovoUtente(utente1);
                bool inseridoUtente2 = regrasNegocio.NovoUtente(utente2);

                if (inseridoUtente1 && inseridoUtente2)
                {
                    Console.WriteLine("Utentes inseridos com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível inserir todos os utentes.");
                }

              
                List<Utente> listaUtentes = Utentes.EnviarTodosUtentes();

                Console.WriteLine("\nLista de Utentes:");
                foreach (var utente in listaUtentes)
                {
                    Console.WriteLine($"Nome: {utente.Nome}, Idade: {utente.Idade}, Estado: {utente.Estado}");
                }

                string filenameUtentes = "utentes.dat";
                bool sucessoGravacaoUtentes = RN.GravarFicheiroUtentes(filenameUtentes);

                if (sucessoGravacaoUtentes)
                {
                    Console.WriteLine("Informações dos utentes gravadas com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível gravar as informações dos utentes.");
                }
            }
            catch (AuxiliarException ex)
            {
                Console.WriteLine($"Erro ao inserir o auxiliar: {ex.Message}");
            }
            catch (UtenteException ex)
            {
                Console.WriteLine($"Erro ao inserir o utente: {ex.Message}");
            }
            catch (LeituraFicheiroException ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
            }

           
            string namefile = "utentes.dat";
            bool sucessoLeitura = false;

            try
            {
                sucessoLeitura = RN.LerFicheiroUtentes(namefile);

                if (sucessoLeitura)
                {
                    List<Utente> listutenteslidos = Utentes.EnviarTodosUtentes();

                    Console.WriteLine("\nLista de Utentes Lidos do Ficheiro:");
                    foreach (var utente in listutenteslidos)
                    {
                        Console.WriteLine($"Nome: {utente.Nome}, Idade: {utente.Idade}, Estado: {utente.Estado}");
                    }
                }
                else
                {
                    Console.WriteLine("Não foi possível ler as informações dos utentes do ficheiro.");
                }
            }
            catch (LeituraFicheiroException ex)
            {
                Console.WriteLine($"Erro ao ler o ficheiro de utentes: {ex.Message}");
            }

        }
    }
}
