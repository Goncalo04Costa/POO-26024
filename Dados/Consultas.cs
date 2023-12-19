using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ObjetosdeNegocio;
using Excecao;

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



        #region Propriedade
        /// <summary>
        /// Devolve uma copia da lista de consultas.
        /// </summary>
        /// <value>
        /// The todas assistencias.
        /// </value>
        public List<Consulta> ObterConsultas
        {
            get
            {
                return ConsultasList.ToList();
            }
        }
        #endregion


     

       /// <summary>
       /// Apresenta o  numero de consultas
       /// </summary>
       /// <returns></returns>
        public int ContaConsultas()
        {
            return ConsultasList.Count; 
        }

        /// <summary>
        /// Método estático para inserir uma nova consuulta na lista estática compartilhada.
        /// </summary>
        /// <param name="novoAuxiliar">Consulta a ser inserido na lista.</param>
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
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
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
                throw new LeituraFicheiroConsultaException("Erro ao ler o ficheiro de consultas: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
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
            catch (EscritaFicheiroConsultasException e)
            {
                throw new EscritaFicheiroConsultasException("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }


        /// <summary>
        /// apresentar as consultas  por ordem
        /// </summary>
        public void OrdenarConsultasPorData()
        {
            ConsultasList.Sort();
        }


    }
}
