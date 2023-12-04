using ObjetosdeNegocio;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IFuncionario
    {
        bool InsereFuncionarioLista(Funcionario novoFuncionario);

        bool ExisteFuncionario(int codigoFuncionario);

        bool RemoveFunc(int codigoFuncionario);

        bool LerFuncionario(string nomeFicheiro);

        bool GravarFuncionarios(string nomeFicheiro);

        int ContaFunc();
    }
}
