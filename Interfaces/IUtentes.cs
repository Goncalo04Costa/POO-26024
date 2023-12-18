using System.Collections.Generic;
using ObjetosdeNegocio;

namespace Dados
{
    public interface IUtentes
    {
        bool InsereUtenteLista(Utente novoUtente);
        bool ExisteUtente(int Sns);
        bool RemoveUtente(int Nif);
        bool LerUtente(string nomeFicheiro);
        bool GravarUtentes(string nomeFicheiro);
        Utente EncontraUtente(int nif);
        bool DarAltaUtente(int nif);
        bool TransferirUtente(int nif);
        List<Utente> ObterUtentesSemContactoFamiliar();
        List<Utente> ListarUtentes();
        int ContarUtentes();
    }
}
