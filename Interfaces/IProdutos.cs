using System.Collections.Generic;
using ObjetosdeNegocio;

namespace Interfaces
{
    public interface IProdutos
    {
        bool InsereMedicamentoLista(Medicamento novoMedicamento);
        bool RemoverMedicamento(int codigo);
        bool LerMedicamento(string nomeFicheiro);
        bool GravarMedicamentos(string nomeFicheiro);
    }
}
