/*
*	<copyright file="Funcionarios" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 04/12/2023 09:07:27</date>
*	<description></description>
**/


using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using Excecao;
using ObjetosdeNegocio;

namespace Dados
{
    /// <summary>
    /// A classe Funcionarios gerencia uma lista de funcionários.
    /// </summary>
    public class Funcionarios
    {
        private static List<Medico> medicoslist;
        private static List<Enfermeiro> enfermeirosList;
        private static List<Auxiliar> auxiliaresList;


        static Funcionarios()
        {
            medicoslist = new List<Medico>();
            enfermeirosList = new List<Enfermeiro>();
            auxiliaresList = new List<Auxiliar>();
        }


        public Funcionarios() { }


     

        /// <summary>
        /// Método estático para inserir um novo auxiliar na lista estática compartilhada.
        /// </summary>
        /// <param name="novoAuxiliar">O auxiliar a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereAuxiliarLista(Auxiliar novoAuxiliar)
        {


            foreach (Auxiliar aux in auxiliaresList)
            {
                if (aux.Equals(novoAuxiliar))
                {
                    throw new AuxiliarException("Já existe este auxiliar na lista.");
                }
            }

            auxiliaresList.Add(novoAuxiliar);
            return true;

        }

        /// <summary>
        /// Método estático para inserir um novo auxiliar na lista estática compartilhada.
        /// </summary>
        /// <param name="novoAuxiliar">O auxiliar a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereEnfermeiroLista(Enfermeiro novoEnfermeiro)
        {


            foreach (Enfermeiro aux in enfermeirosList)
            {
                if (aux.Equals(novoEnfermeiro))
                {
                    throw new EnfermeiroException("Já existe este enfermeiro na lista.");
                }
            }

            enfermeirosList.Add(novoEnfermeiro);
            return true;

        }

        /// <summary>
        /// Método estático para inserir um novo medico na lista estática compartilhada.
        /// </summary>
        /// <param name="novofunc">O medico a ser inserido na lista.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InsereMedicoLista(Medico novomedico)
        {


            foreach (Medico aux in medicoslist)
            {
                if (aux.Equals(novomedico))
                {
                    throw new MedicamentoException("Já existe este medico na lista.");
                }
            }

            medicoslist.Add(novomedico);
            return true;

        }


        

        /// <summary>
        /// Verifica se um medico com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="codigom">O código do medico a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public static bool ExisteMedico(int codigoMedico, out Medico m)
        {
            foreach (Medico b in medicoslist)
            {
                if (b.Codigo == codigoMedico)
                {
                    m = b;
                    return true;
                }
            }
            m = null;
            return false;
        }
        /// <summary>
        /// Verifica se um enfermeiro com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="codigoEnfermeiro">O código do auxiliar a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public static bool ExisteEnfermeiro(int codigoEnfermeiro, out Enfermeiro e)
        {
            foreach (Enfermeiro b in enfermeirosList)
            {
                if (b.Codigo == codigoEnfermeiro)
                {
                    e = b;
                    return true;
                }
            }
            e = null;
            return false;
        }



        /// <summary>
        /// Verifica se um auxiliar com o código especificado existe na lista estática compartilhada.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do auxiliar a ser verificado.</param>
        /// <returns>True se o auxiliar existir na lista, False caso contrário.</returns>
        public static bool ExisteAuxiliar(int codigoAuxiliar, out Auxiliar a)
        {
            foreach (Auxiliar b in auxiliaresList)
            {
                if (b.Codigo == codigoAuxiliar)
                {
                    a = b;
                    return true;
                }
            }
            a = null;
            return false;
        }



        


        /// <summary>
        /// Remove um medico com base no seu código.
        /// </summary>
        /// <param name="cod">O código do medico a ser removido.</param>
        /// <returns>True se o medico foi removido com sucesso, False caso contrário.</returns>
        public static bool RemoverMedico(int cod)
        {
            Medico medico = medicoslist.Find(a => a.CodigoMedico == cod);
            if (medico != null)
            {
                medicoslist.Remove(medico);
                return true;
            }
            return false;
        }




        /// <summary>
        /// Remove um auxiliar com base no seu código.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do auxiliar a ser removido.</param>
        /// <returns>True se o auxiliar foi removido com sucesso, False caso contrário.</returns>
        public static bool RemoveEnfermeiro(int codigoenfermeiro)
        {
            Enfermeiro enfermeiro = enfermeirosList.Find(a => a.CodigoEnfermeiro == codigoenfermeiro);
            if (enfermeiro != null)
            {
                enfermeirosList.Remove(enfermeiro);
                return true;
            }
            return false;
        }



        /// <summary>
        /// Remove um auxiliar com base no seu código.
        /// </summary>
        /// <param name="codigoAuxiliar">O código do auxiliar a ser removido.</param>
        /// <returns>True se o auxiliar foi removido com sucesso, False caso contrário.</returns>
        public  static bool RemoverAuxiliar(int codigoAuxiliar)
        {
            Auxiliar auxiliar = auxiliaresList.Find(a => a.CodigoAuxiliar == codigoAuxiliar);
            if (auxiliar != null)
            {
                auxiliaresList.Remove(auxiliar);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Remove todas os auxiliares da lista de auxiliares.
        /// </summary>
        /// <returns></returns>
        public static bool RemoverAuxiliares()
        {
            auxiliaresList.Clear();
            return true;
        }

        /// <summary>
        /// Remove todas os medicos da lista de medicos.
        /// </summary>
        /// <returns></returns>
        public static bool RemoverMedicos()
        {
            medicoslist.Clear();
            return true;
        }

        /// <summary>
        /// Remove todas os enfermeiros da lista de medicos.
        /// </summary>
        /// <returns></returns>
        public static bool RemoverEnfermeiros()
        {
            enfermeirosList.Clear();
            return true;
        }



        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GravarMedicos(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, medicoslist);
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
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GravarEnfermeiros(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, enfermeirosList);
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
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GravarAuxiliares(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, auxiliaresList);
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
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public static bool LerMedicos(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    medicoslist = (List<Medico>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroException("Erro ao ler o ficheiro de medicos: " + ex.Message);
            }
        }



        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public static bool LerEnfermeiros(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    enfermeirosList = (List<Enfermeiro>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroException("Erro ao ler o ficheiro de enfermeiros: " + ex.Message);
            }
        }



        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public static bool LerAuxiliares(string nomeFicheiro)
        {
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;

                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    auxiliaresList = (List<Auxiliar>)b.Deserialize(ficheiro);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new LeituraFicheiroException("Erro ao ler o ficheiro de auxiliares: " + ex.Message);
            }
        }





        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de auxiliares.
        /// </summary>
        /// <returns>Uma lista contendo todos os auxiliares.</returns>
        public static List<Auxiliar> EnviarTodosAuxiliares()
        {
            return auxiliaresList.ToList();
        }

        /// <summary>
        /// Retorna o número total de auxiliares na lista.
        /// </summary>
        /// <returns>O número total de auxiliares.</returns>
        public int ContaAuxiliares()
        {
            return auxiliaresList.Count;
        }

        /// <summary>
        /// apresentar os auxiliares  por ordem de entrada
        /// </summary>
        public void OrdenarConsultasPorData()
        {
            auxiliaresList.Sort();
        }


        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de enfermeiros.
        /// </summary>
        /// <returns>Uma lista contendo todos os enfermeiros.</returns>
        public static List<Enfermeiro> EnviarTodosEnfermeiros()
        {
            return enfermeirosList.ToList();
        }

        /// <summary>
        /// Retorna o número total de enfermeiros na lista.
        /// </summary>
        /// <returns>O número total de enfermeiros.</returns>
        public int ContaEnfermeiros()
        {
            return enfermeirosList.Count;
        }



        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de enfermeiros.
        /// </summary>
        /// <returns>Uma lista contendo todos os enfermeiros.</returns>
        public static List<Medico> EnviarTodosMedicos()
        {
            return medicoslist.ToList();
        }

        /// <summary>
        /// Método estático que retorna uma cópia da lista estática compartilhada de medicos.
        /// </summary>
        /// <returns>Uma lista contendo todos os medicos.</returns>
        public List<Medico> ListarMedicos()
        {
            return medicoslist.ToList();
        }

        /// <summary>
        /// Retorna o número total de medicos na lista.
        /// </summary>
        /// <returns>O número total de medicos.</returns>
        public int ContarMedicos()
        {
            return medicoslist.Count;
        }

    }
}
