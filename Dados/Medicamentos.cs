/*
*	<copyright file="Medicamentos" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 07/12/2023 10:17:55</date>
*	<description></description>
**/


using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO; 
using Excecao;
using ObjetosdeNegocio;

namespace Dados
{
    /// <summary>
    /// Classe que representa uma coleção dinâmica de Medicamentos.
    /// </summary>
    public class Medicamentos
    {
        private static List<Medicamento> medicamentosList; 

        static Medicamentos()
        {
            medicamentosList = new List<Medicamento>(); 
        }

        public Medicamentos()
        {

        }

        /// <summary>
        /// Obtem a lista de medicamentos
        /// </summary>
        public List<Medicamento> MedicamentosList
        {
            get { return medicamentosList; }
        }

        /// <summary>
        /// Método estático para inserir um novo medicamento na lista estática compartilhada.
        /// </summary>
        /// <param name="novofunc">O medicamento a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereMedicamentoLista(Medicamento novoMedicamento)
        {
            Medicamento medicamentoExistente = medicamentosList.Find(m => m.Codigo == novoMedicamento.Codigo);

            if (medicamentoExistente != null)
            {
                medicamentoExistente.Stock++; 
            }
            else
            {
                novoMedicamento.Stock = 1; 
                medicamentosList.Add(novoMedicamento);
            }

            return true;
        }

        /// <summary>
        /// Função para remover um medicamento da lista
        /// </summary>
        /// <param name="codigo">Medicamento a remover</param>
        /// <returns>True se a remoçao foi bem feita, false o contrario</returns>
        public bool RemoverMedicamento(int codigo)
        {
            Medicamento medicamentoParaRemover = medicamentosList.Find(m => m.Codigo == codigo);
            if (medicamentoParaRemover != null)
            {
          
                medicamentoParaRemover.Stock--;

               
                if (medicamentoParaRemover.Stock == 0)
                {
                    medicamentosList.Remove(medicamentoParaRemover);
                }

                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public static bool LerMedicamento(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    medicamentosList = (List<Medicamento>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroException("Erro ao ler o ficheiro de medicamentos: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GravarMedicamentos(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, medicamentosList);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }

    }

}
