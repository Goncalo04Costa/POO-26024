using System.Collections.Generic;
using ObjetosdeNegocio;
using Dados;

namespace Interfaces
{
    public interface IEnfermeiros
    {
        bool InsereEnfermeiroLista(Enfermeiro novoEnfermeiro);

        bool ExisteEnfermeiro(int codigoenfermeiro);

        bool RemoveEnfermeiro(int codigoenfermeiro);

        bool LerEnfermeiros(string nomeFicheiro);

        bool GravarEnfermeiros(string nomeFicheiro);

        int ContaEnfermeiros();
    }
}
