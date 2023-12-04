/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using Excecao;
using ObjetosdeNegocio;

namespace Dados
{
    /// <summary>
    /// Classe responsável por gerir um conjunto de médicos.
    /// </summary>
    public class Medicos
    {
        private static List<Medico> medicosList; 

        public Medicos()
        {
            medicosList = new List<Medico>(); // Inicializando a lista vazia
        }

        public List<Medico> MedicosList
        {
            get { return medicosList; }
        }

        /// <summary>
        /// Método estático para inserir um novo medico na lista estática compartilhada.
        /// </summary>
        /// <param name="novofunc">O medico a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereMedicoLista(Medico novomedico)
        {


            foreach (Medico aux in medicosList)
            {
                if (aux.Equals(novomedico))
                {
                    throw new MedicamentoException("Já existe este medico na lista.");
                }
            }

            medicosList.Add(novomedico);
            return true;

        }

        /// <summary>
        /// Verifica se um medico com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="codigom">O código do medico a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public bool ExisteMedico(int codigom)
        {
            return medicosList.Any(a => a.CodigoMedico == codigom );
        }


        /// <summary>
        /// Remove um medico com base no seu código.
        /// </summary>
        /// <param name="cod">O código do medico a ser removido.</param>
        /// <returns>True se o medico foi removido com sucesso, False caso contrário.</returns>
        public bool RemoveFunc(int cod)
        {
            Medico medico = medicosList.Find(a => a.CodigoMedico == cod);
            if (medico != null)
            {
                medicosList.Remove(medico);
                return true;
            }
            return false;
        }



        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool LerMedicos(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    medicosList = (List<Medico>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroMedicoException("Erro ao ler o ficheiro de medicos: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GravarFuncionarios(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, medicosList);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiroMedicosException e)
            {
                throw new EscritaFicheiroMedicosException("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }

        public List<Medico> ListarMedicos()
        {
            return new List<Medico>(medicosList); 
        }

        public int ContarMedicos()
        {
            return medicosList.Count;
        }
    }
}
