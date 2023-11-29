/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */
using System;
using System.Collections.Generic;
using Consultas;
using Persons; // Importante incluir o namespace Persons para ter acesso às classes de Utentes e Utente

namespace Con
{
    public class Consultas
    {
        private List<Consulta> ConsultasList;
        private Utentes listaUtentes; // Adicionando a lista de Utentes como atributo

        public Consultas(Utentes utentes)
        {
            ConsultasList = new List<Consulta>(); // Inicializando a lista vazia
            listaUtentes = utentes; // Recebendo a lista de Utentes ao criar Consultas
        }

        public List<Consulta> Consultaslist
        {
            get { return ConsultasList; }
        }

        public bool AdicionarConsulta(Consulta consulta)
        {
            ConsultasList.Add(consulta); // Adicionando a consulta à lista
            return true; // Não há um limite fixo, sempre pode adicionar
        }

        public bool RemoveConsulta(int codigo)
        {
            Consulta consultaremover = ConsultasList.Find(c => c.Consultaid == codigo);
            if (consultaremover != null)
            {
                ConsultasList.Remove(consultaremover); // Removendo a consulta da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Consulta> ListaConsultas()
        {
            return new List<Consulta>(ConsultasList); // Retorna uma nova lista de consultas
        }

        public int ContaConsultas()
        {
            return ConsultasList.Count; // Contando o número de consultas na lista
        }

        public bool VerificarContactoFamiliarPorSNS(int snsConsulta, Utentes listaDeUtentes)
        {
            // Procurar o utente na lista pelo número de SNS
            Utente utenteEncontrado = listaDeUtentes.UtentesList.Find(u => u.Nif == snsConsulta);

            if (utenteEncontrado != null)
            {
                // Verificar se o contacto familiar é igual a 0
                if (utenteEncontrado.ContactoFamiliarProperty == 0)
                {
                    // Se o contacto familiar for 0, mostrar mensagem ou realizar ação desejada
                    Console.WriteLine("É necessário chamar transporte para este utente.");
                    return true; // Ou executa alguma outra ação necessária
                }
                else
                {
                    // Se o contacto familiar for diferente de 0
                    Console.WriteLine("Contacto familiar disponível para este utente.");
                    return false; // Ou executa outra ação caso necessário
                }
            }
            else
            {
                // Se o utente não for encontrado
                Console.WriteLine("Utente não encontrado.");
                return false; // Ou executa outra ação caso necessário
            }
        }

    }
}
