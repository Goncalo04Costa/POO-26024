/*
*	<copyright file="RN" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 02/12/2023 10:34:03</date>
*	<description></description>
**/

using Dados;
using ObjetosdeNegocio;
using Excecao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace RegrasdeNegocio
{
    public class RN
    {

        /// <summary>
        /// Insere um novo medico, mas so pode ser de clinica geral
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        /// <exception cref="MedicoException"></exception>
        public bool InsereMedico(Medico medico)
        {
            if (medico.Especialidade != "Clínica Geral")
            {
                return false;
            }
            try
            {
                Funcionarios.InsereMedicoLista(medico);
                return true;
            }
            catch (MedicoException e)
            {
                throw new MedicoException("Falha de Regras de Negocio " + "-" + e.Message);
            }
        }

        /// <summary>
        /// Insere um novo enfermeiro, mas so pode ser de geral
        /// </summary>
        /// <param name="enfermeiro"></param>
        /// <returns></returns>
        /// <exception cref="EnfermeiroException"></exception>
        public bool InsereEnfermeiro(Enfermeiro enfermeiro)
        {
            if (enfermeiro.Cargo != "Enfermeiro Geral" )
            {
                return false;
            }
            try
            {
                Funcionarios.InsereEnfermeiroLista(enfermeiro);
                return true;
            }
            catch (EnfermeiroException e)
            {
                throw new EnfermeiroException("Falha de Regras de Negocio " + "-" + e.Message);
            }
        }


        /// <summary>
        /// Insere um novo auxiliar, mas so pode ser de Copa
        /// </summary>
        /// <param name="auxiliar"></param>
        /// <returns></returns>
        /// <exception cref="AuxiliarException"></exception>
        public bool InsereAuxiliar(Auxiliar auxiliar)
        {
            if (auxiliar.Cargo != "Copa")
            {
                return false;
            }
            try
            {
                Funcionarios.InsereAuxiliarLista(auxiliar);
                return true;
            }
            catch (AuxiliarException e)
            {
                throw new AuxiliarException("Falha de Regras de Negocio " + "-" + e.Message);
            }
        }




        /// <summary>
        /// Grava toda a informação acerca dos auxiliares.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="EscritaFicheiroAuxiliaresException"></exception>
        public static bool GravarFicheiroAuxiliares(string nomeFicheiro)
        {
            try
            {
                Funcionarios.GravarAuxiliares(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }



        /// <summary>
        /// Grava toda a informação acerca dos medicos.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="EscritaFicheiroMedicosException"></exception>
        public static bool GravarFicheiroMedicos(string nomeFicheiro)
        {
            try
            {
                Funcionarios.GravarMedicos(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }

        /// <summary>
        /// Grava toda a informação acerca dos enfermeiros.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="EscritaFicheiroEnfermeirosException"></exception>
        public static bool GravarFicheiroEnfermeiros(string nomeFicheiro)
        {
            try
            {
                Funcionarios.GravarEnfermeiros(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }


        /// <summary>
        /// Grava toda a informação acerca dos medicamentos.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="EscritaFicheiro"></exception>
        public static bool GravarFicheiroMedicamentos(string nomeFicheiro)
        {
            try
            {
                Medicamentos.GravarMedicamentos(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }


        /// <summary>
        /// Lê toda a informação guardada em ficheiro, acerca dos medicos.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="LeituraFicheiroMedicoException"></exception>
        public static bool LerFicheiroMedicos(string nomeFicheiro)
        {
            try
            {
                Funcionarios.LerMedicos(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiroException e)
            {
                throw new LeituraFicheiroException(e.Message + " - " + " Erro ao ler o ficheiro.");
            }
        }


        /// <summary>
        /// Lê toda a informação guardada em ficheiro, acerca dos medicamentos.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="LeituraFicheiroException"></exception>
        public static bool LerFicheiroMedicamentos(string nomeFicheiro)
        {
            try
            {
                Medicamentos.LerMedicamento(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiroException e)
            {
                throw new LeituraFicheiroException(e.Message + " - " + " Erro ao ler o ficheiro.");
            }
        }



        /// <summary>
        /// Lê toda a informação guardada em ficheiro, acerca dos enfermeiros.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="LeituraFicheiroEnfermeiroException"></exception>
        public static bool LerFicheiroEnfermeiros(string nomeFicheiro)
        {
            try
            {
                Funcionarios.LerEnfermeiros(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiroException e)
            {
                throw new LeituraFicheiroException(e.Message + " - " + " Erro ao ler o ficheiro.");
            }
        }


        /// <summary>
        /// Lê toda a informação guardada em ficheiro, acerca dos auxiliares.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="LeituraFicheiroAuxiliarException"></exception>
        public static bool LerFicheiroAuxiliares(string nomeFicheiro)
        {
            try
            {
                Funcionarios.LerAuxiliares(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiroException e)
            {
                throw new LeituraFicheiroException(e.Message + " - " + " Erro ao ler o ficheiro.");
            }
        }

        /// <summary>
        /// Novo utente, tendo em conta que so será inserido pelo seu estado
        /// </summary>
        /// <param name="utente"></param>
        /// <returns></returns>
        /// <exception cref="UtenteException"></exception>
        public bool NovoUtente(Utente utente)
        {
            if (!(utente.Estado == 0 || utente.Estado == 1))
            {
                return false;
            }

            try
            {
                Utentes.InsereUtenteLista(utente);
                return true;
            }
            catch (UtenteException e)
            {
                throw new UtenteException("Falha de Regras de Negocio - " + e.Message);
            }

        }


        /// <summary>
        /// Remove um utente da lista com base no seu estado.
        /// </summary>
        /// <param name="utente">O utente a ser removido.</param>
        /// <returns>True se o utente foi removido com sucesso, False caso contrário.</returns>
        /// <exception cref="UtenteException">Exceção relacionada com a remoção do utente.</exception>
        public bool AltaaUtente(Utente utente)
        {
            if (utente.Estado != 2)
            {
                return false;
            }

            try
            {
                Utentes.RemoveUtente(utente.Nif);
                return true;
            }
            catch (UtenteException e)
            {
                throw new UtenteException("Falha de Regras de Negocio - " + e.Message);
            }
        }


        /// <summary>
        /// Metodo que verifica se pode enviar a lista de consultas
        /// </summary>
        /// <returns>Lista de campanhas</returns>
        public static List<Consulta> ListaConsultas()
        {
            try
            {
                return Consultas.ObterConsultas;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Insere uma nova consulta
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        /// <exception cref="ConsultaException"></exception>
        public bool NovaConsulta(Consulta consulta)
        {
            if(consulta.Data > DateTime.Now)
            {
                return false;
            }

            if (consulta.Distancia > 250)
            {
                return false; 
            }

            try
            {
                Consultas.InsereConsultaLista(consulta); 
                return true; 
            }
            catch (ConsultaException e)
            {
                throw new ConsultaException("Falha de Regras de Negócio - " + e.Message);
            }
        }


        /// <summary>
        /// Procura ver se é possivel remover consulta
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        /// <exception cref="ConsultaException"></exception>
        public bool RemoveConsulta(Consulta consulta)
        {
            DateTime dataLimite = DateTime.Today.AddDays(5);
            if (consulta.Data < dataLimite)
            {
                return false;
            }

            try
            {
                Consultas.RemoverConsulta(consulta.Consultaid);
                return true;
            }
            catch (ConsultaException e)
            {
                throw new ConsultaException("Falha de Regras de Negócio - " + e.Message);
            }
        }

        /// <summary>
        /// Procura ver se é possível remover auxiliar
        /// </summary>
        /// <param name="auxiliar"></param>
        /// <returns></returns>
        /// <exception cref="AuxiliarException"></exception>
        public bool RemoveAuxiliar(Auxiliar auxiliar)
        {
            Funcionarios funcionarios = new Funcionarios();

            if (funcionarios.ContaAuxiliares() < 6)
            {
                return false;
            }

            try
            {
                Funcionarios.RemoverAuxiliar(auxiliar.Codigo);
                return true;
            }
            catch (AuxiliarException e)
            {
                throw new AuxiliarException("Falha de Regras de Negócio - " + e.Message);
            }
        }

        /// <summary>
        /// Procura ver se é possível remover medico
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        /// <exception cref="MedicoException"></exception>
        public bool RemoveMedico(Medico medico)
        {
            Funcionarios funcionarios = new Funcionarios();

            if (funcionarios.ContarMedicos() < 2)
            {
                return false;
            }

            try
            {
                Funcionarios.RemoverMedico(medico.Codigo);
                return true;
            }
            catch (AuxiliarException e)
            {
                throw new AuxiliarException("Falha de Regras de Negócio - " + e.Message);
            }
        }


        /// <summary>
        /// Procura ver se é possível remover enfermeiro
        /// </summary>
        /// <param name="enfermeiro"></param>
        /// <returns></returns>
        /// <exception cref="EnfermeiroException"></exception>
        public bool RemoveEnfermeiro(Enfermeiro enfermeiro)
        {
            Funcionarios funcionarios = new Funcionarios();

            if (funcionarios.ContaEnfermeiros() < 4)
            {
                return false;
            }

            try
            {
                Funcionarios.RemoveEnfermeiro(enfermeiro.Codigo);
                return true;
            }
            catch (EnfermeiroException e)
            {
                throw new EnfermeiroException("Falha de Regras de Negócio - " + e.Message);
            }
        }
    }

}
 
