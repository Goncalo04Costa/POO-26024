using System;
using ObjetosdeNegocio;
using Dados;
using Excecao;
using System.Collections.Generic;

namespace Main
{
    class IO
    {
        static void Main(string[] args)
        {
            // Criando alguns auxiliares (você pode removê-los desta parte)
            Auxiliar auxiliar1 = new Auxiliar(1, "01/01/2023", "Cargo1", 123456789, 1001, "Condição1", "Jose", "Pedro", 30, 123456789, 987654321);
            Auxiliar auxiliar2 = new Auxiliar(2, "02/02/2023", "Cargo2", 987654321, 1002, "Condição2", "Lionela", "Messiana", 35, 987654321, 123456789);

            
                // Chamando métodos estáticos da classe Funcionarios para manipular os auxiliares
                Funcionarios.InsereAuxiliarLista(auxiliar1);
                Funcionarios.InsereAuxiliarLista(auxiliar2);

                // Testando o método para enviar todos os auxiliares
                Console.WriteLine("Lista de todos os auxiliares:");
                List<Auxiliar> todosAuxiliares = Funcionarios.EnviarTodosAuxiliares();
                foreach (var auxiliar in todosAuxiliares)
                {
                    Console.WriteLine(auxiliar.ToString());
                }

            int codigoARemover = 1;
            bool removido = Funcionarios.RemoverAuxiliar(codigoARemover);
                if (removido)
                {
                    Console.WriteLine("Auxiliar removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível remover o auxiliar.");
                }

                int codigoAProcurar = 2;
                bool existe = Funcionarios.ExisteAuxiliar(codigoAProcurar);
                if (existe)
                {
                    Console.WriteLine("O auxiliar existe na lista.");
                }
                else
                {
                    Console.WriteLine("O auxiliar não foi encontrado na lista.");
                }

                // Tentativa de gravar e ler de um arquivo (não testado)
                string nomeArquivo = "auxiliares.bin";
                bool gravadoComSucesso = Funcionarios.GravarAuxiliares(nomeArquivo);
                if (gravadoComSucesso)
                {
                    bool leituraBemSucedida = Funcionarios.LerAuxiliares(nomeArquivo);
                    if (leituraBemSucedida)
                    {
                        Console.WriteLine("Leitura do arquivo de auxiliares bem-sucedida.");
                    }
                    else
                    {
                        Console.WriteLine("Erro na leitura do arquivo de auxiliares.");
                    }
                }
                else
                {
                    Console.WriteLine("Erro ao gravar o arquivo de auxiliares.");
                }
            }
            
        }
    }

