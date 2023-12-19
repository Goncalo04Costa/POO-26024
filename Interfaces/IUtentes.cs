/*
*	<copyright file="IUtentes" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 12/11/2023 13:22:23</date>
*	<description></description>
**/

using System.Collections.Generic;
using ObjetosdeNegocio;
using Dados;

namespace Dados
{
    public interface IUtentes
    {
        bool InsereUtenteLista(Utente novoUtente);
        bool ExisteUtente(int Sns);
        bool RemoveUtente(int Nif);
        bool LerUtente(string nomeFicheiro);
        bool GravarUtentes(string nomeFicheiro);
        bool RemoverUtentes();
        Utente EncontraUtente(int nif);
        bool DarAltaUtente(int nif);
        List<Utente> ObterUtentesSemContactoFamiliar();
        List<Utente> ListarUtentes();
        int ContarUtentes();
        void OrdenarConsultasPorData();
    }
}
