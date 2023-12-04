using System.Collections.Generic;
using ObjetosdeNegocio;
using Dados;

namespace Interfaces
{
    public interface IAuxiliares
    {
        bool ExisteAuxiliar(int codigoAuxiliar);
        bool RemoverAuxiliar(int codigoAuxiliar);
        bool LerAuxiliares(string nomeFicheiro);
        bool GravarAuxiliares(string nomeFicheiro);
        List<Auxiliar> EnviarTodosAuxiliares();
        int ContaAuxiliares();
    }
}
