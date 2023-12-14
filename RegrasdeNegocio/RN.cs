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
     

        public bool InsereMedico(Medico medico)
        {
            if (medico.Especialidade != "Clínica Geral")
            {
                return false;
            }
            try
            {
                Medicos.InsereMedicoLista(medico);
                return true;
            }
            catch (MedicoException e)
            {
                throw new MedicoException("Falha de Regras de Negocio " + "-" + e.Message);
            }
        }



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


        /*public bool AltaaUtente(Utente utente)
        {
            if(utente.Estado !=2)
            {
                return false;
            }

            try
            {
                Utentes.DarAltaUtente(utente.Nif);
                return true;
            }
            catch (UtenteException e)
            {
                throw new UtenteException("Falha de Regras de Negocio - " + e.Message);


            }

        }*/
}



        /*
         * Utente de estado 2 desaparecem da lista
         * Codigo de fornecedor tem de ser entre 100 e 199
         * Maxima distancia para consulta são 250km
         * Codigo medico consulta != codigo medico ucci
         * Codigo SNS de utente == Codigo Utente consulta
         * */


    }


 
