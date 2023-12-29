/*
*	<copyright file="Consultas" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 27/11/2023 17:57:35</date>
*	<description></description>
**/

using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ObjetosdeNegocio;
using Excecao;
using Interfaces;

namespace Dados
{
    public class Consultas 
    {
        private static List<Consulta> ConsultasList; 
        
      


        /// <summary>
        /// Inicialização da lista de consultas
        /// </summary>
        static Consultas()
        {
            ConsultasList = new List<Consulta>(); 
        }


        /// <summary>
        /// Construtor por defeito.
        /// </summary
        public Consultas()
        {

        }



        
        /// <summary>
        /// Devolve uma copia da lista de consultas.
        /// </summary>
        /// <value>
        /// The todas assistencias.
        /// </value>
        public static List<Consulta> ObterConsultas
        {
            get
            {
                return ConsultasList.ToList();
            }
        }
        

     

       /// <summary>
       /// Apresenta o  numero de consultas
       /// </summary>
       /// <returns> o numero de consultas</returns>
        public int ContaConsultas()
        {
            return ConsultasList.Count; 
        }

        /// <summary>
        /// Método estático para inserir uma nova consuulta na lista estática compartilhada.
        /// </summary>
        /// <param name="novoConsulta">Consulta a ser inserida na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereConsultaLista(Consulta novoConsulta)
        {


            foreach (Consulta aux in ConsultasList)
            {
                if (aux.Equals(novoConsulta))
                {
                    throw new ConsultaException("Já existe esta consulta na lista.");
                }
            }

            ConsultasList.Add(novoConsulta);
            return true;

        }



        /// <summary>
        /// Remove uma consulta com base no seu código de id.
        /// </summary>
        /// <param name="cod">O código da consutla a ser removida.</param>
        /// <returns>True se a consulta foi removido com sucesso, False caso contrário.</returns>
        public static bool RemoverConsulta(int cod)
        {
            Consulta consulta  = ConsultasList.Find(a => a.Consultaid == cod);
            if (consulta != null)
            {
                ConsultasList.Remove(consulta);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Remove todas as consultas da lista de consultas.
        /// </summary>
        /// <returns>true se limpou</returns>
        public static bool RemoverConsultas()
        {
            ConsultasList.Clear();
            return true;
        }



        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns>true se deu e false o contrario</returns>
        public bool LerConsultas(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    ConsultasList = (List<Consulta>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroException("Erro ao ler o ficheiro de consultas: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns> true se gravou e false caso contrario</returns>
        public bool GravarConsultas(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, ConsultasList);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }


        /// <summary>
        /// apresentar as consultas  por ordem
        /// </summary>
        public static void OrdenarConsultasPorData()
        {
            ConsultasList.Sort((c1, c2) => c1.Data.CompareTo(c2.Data));
        }



        /// <summary>
        /// Retorna a próxima consulta tendo em conta a sua data  .
        /// </summary>
        /// <param name="consultas">A lista de consultas.</param>
        /// <returns>A próxima consulta </returns>
        public static Consulta ProximaConsulta(List<Consulta> consultas)
        {
            DateTime dataAtual = DateTime.Today;
            Consulta proximaConsulta = null;
            TimeSpan menorDiferenca = TimeSpan.MaxValue;

            foreach (Consulta consulta in consultas)
            {
                TimeSpan diferenca = consulta.Data - dataAtual;
                if (diferenca > TimeSpan.Zero && diferenca < menorDiferenca)
                {
                    menorDiferenca = diferenca;
                    proximaConsulta = consulta;
                }
            }

            return proximaConsulta;
        }


        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de consultas.
        /// </summary>
        /// <returns>Uma lista contendo todas as consultas.</returns>
        public static List<Consulta> EnviarCOnsultas()
        {
            return ConsultasList.ToList();
        }


    }
}
