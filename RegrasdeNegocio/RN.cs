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
        /// 
        /// </summary>
        /// <param name="idMedico"></param>
        /// <returns></returns>
        /// <exception cref="MedicoException"></exception>
        public bool RemoveMedico(int idMedico)
        {
            Funcionarios medicosInstance = new Funcionarios();
            if (medicosInstance.ContarMedicos() > 1)
            {
                try
                {
                    return medicosInstance.RemoverMedico(idMedico);
                }
                catch (MedicoException e)
                {
                    throw new MedicoException("Falha de Regras de Negócio " + "-" + e.Message);
                }
            }
            else
            {
                
                throw new MedicoException("Não é permitido remover o último médico da lista.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idenfermeiro"></param>
        /// <returns></returns>
        /// <exception cref="EnfermeiroException"></exception>
        public bool RemoveEnfermeiro(int idenfermeiro)
        {
            Funcionarios enfermeirosInstance = new Funcionarios();
            if (enfermeirosInstance.ContaEnfermeiros() > 2)
            {
                try
                {
                    return enfermeirosInstance.RemoveEnfermeiro(idenfermeiro);
                }
                catch (EnfermeiroException e)
                {
                    throw new EnfermeiroException("Falha de Regras de Negócio " + "-" + e.Message);
                }
            }
            else
            {

                throw new EnfermeiroException("Não é permitido remover o último enfermeiro da lista.");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAuxiliar"></param>
        /// <returns></returns>
        /// <exception cref="AuxiliarException"></exception>
        public bool RemoveAuxiliar(int idAuxiliar)
        {
            Funcionarios auxilaresInstance = new Funcionarios();
            if (auxilaresInstance.ContaAuxiliares() > 6)
            {
                try
                {
                    return auxilaresInstance.RemoverAuxiliar(idAuxiliar);
                }
                catch (AuxiliarException e)
                {
                    throw new AuxiliarException("Falha de Regras de Negócio " + "-" + e.Message);
                }
            }
            else
            {

                throw new AuxiliarException("Não é permitido remover o/a auxiliar da lista.");
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
 
