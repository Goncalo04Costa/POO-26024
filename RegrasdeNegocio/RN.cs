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
        /// 
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
        /// 
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
        /// 
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
            catch (EscritaFicheiroAuxiliaresException e)
            {
                throw new EscritaFicheiroAuxiliaresException(e.Message + " - " + "Erro ao gravar ficheiro");
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
            catch (EscritaFicheiroMedicosException e)
            {
                throw new EscritaFicheiroMedicosException(e.Message + " - " + "Erro ao gravar ficheiro");
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
            catch (EscritaFicheiroEnfermeirosException e)
            {
                throw new EscritaFicheiroEnfermeirosException(e.Message + " - " + "Erro ao gravar ficheiro");
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
            catch (LeituraFicheiroMedicoException e)
            {
                throw new LeituraFicheiroMedicoException(e.Message + " - " + " Erro ao ler o ficheiro.");
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
            catch (LeituraFicheiroEnfermeiroException e)
            {
                throw new LeituraFicheiroEnfermeiroException(e.Message + " - " + " Erro ao ler o ficheiro.");
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
            catch (LeituraFicheiroAuxiliarException e)
            {
                throw new LeituraFicheiroAuxiliarException(e.Message + " - " + " Erro ao ler o ficheiro.");
            }
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="utente"></param>
        /// <returns></returns>
        /// <exception cref="UtenteException"></exception>
        public bool AltaaUtente(Utente utente)
        {
            if (utente.Estado != 2)
            {
                return false;
            }

            try
            {
                Utentes utentesInstance = new Utentes(); 
                utentesInstance.DarAltaUtente(utente.Nif);
                return true;
            }
            catch (UtenteException e)
            {
                throw new UtenteException("Falha de Regras de Negocio - " + e.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="utente"></param>
        /// <returns></returns>
        /// <exception cref="UtenteException"></exception>
        public bool UtenteTransferido(Utente utente)
        {
            if (utente.Estado != 3)
            {
                return false;
            }

            try
            {
                Utentes utentesInstance = new Utentes();
                utentesInstance.TransferirUtente(utente.Nif);
                return true;
            }
            catch (UtenteException e)
            {
                throw new UtenteException("Falha de Regras de Negocio - " + e.Message);
            }
        }

        /// <summary>
        /// 
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

            int SNSutenteConsulta = consulta.SNSutente;
            Utentes utentesInstance = new Utentes(); 

            bool utenteNaLista = utentesInstance.ExisteUtente(SNSutenteConsulta); 

            if (!utenteNaLista)
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
        /// 
        /// </summary>
        /// <param name="limpeza"></param>
        /// <returns></returns>
        /// <exception cref="LimpezaException"></exception>
        public bool NovoProdLimpeza(Limpeza limpeza)
        {
            if (limpeza.Fornecedor < 200 && limpeza.Fornecedor > 100)
            {
                return false;
            }

            try
            {
                Limpezas.InsereProdLimpezaLista(limpeza);
                return true;
            }
            catch (LimpezaException e)
            {
                throw new LimpezaException("Falha de Regras de Negocio - " + e.Message);
            }

        }



    }

}
 
