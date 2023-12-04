using System.Collections.Generic;
using ObjetosdeNegocio;

namespace Dados
{
    public interface IUtentes
    {
        bool InsereUtenteLista(Utente novoutente);
        bool ExisteUtente(int Nif);
        bool RemoveFunc(int Nif);
        bool LerUtente(string nomeFicheiro);
        bool GravarFuncionarios(string nomeFicheiro);
        bool DarAltaUtente(int nif);
        bool AtualizarInformacoesUtente(Utente utente);
        List<Utente> ListarUtentes();
        int ContarUtentes();
    }
}
