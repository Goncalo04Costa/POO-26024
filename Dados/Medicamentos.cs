/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

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
                medicamentoExistente.Quantidade++; // Aumenta a quantidade do medicamento existente
            }
            else
            {
                novoMedicamento.Quantidade = 1; // Define a quantidade como 1 para o novo medicamento
                medicamentosList.Add(novoMedicamento); // Adiciona o novo medicamento à lista
            }

            return true;
        }
        public bool RemoverMedicamento(int codigo)
        {
            Medicamento medicamentoParaRemover = medicamentosList.Find(m => m.Codigo == codigo);
            if (medicamentoParaRemover != null)
            {
                // Reduz a quantidade do medicamento
                medicamentoParaRemover.Quantidade--;

                // Se a quantidade se tornar zero, remove o medicamento da lista
                if (medicamentoParaRemover.Quantidade == 0)
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
        public bool LerMedicamento(string nomeFicheiro)
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
                throw new LeituraFicheiroMedicamentoException("Erro ao ler o ficheiro de medicamentos: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GravarMedicamentos(string nomeFicheiro)
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
            catch (EscritaFicheiroMedicamentoException e)
            {
                throw new EscritaFicheiroMedicamentoException("Erro ao gravar o ficheiro." + e.Message);
            }

            return true;
        }

    }

}
