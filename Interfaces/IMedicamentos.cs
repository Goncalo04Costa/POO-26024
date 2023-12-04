using ObjetosdeNegocio;
using System.Collections.Generic;

namespace Interfaces
{
    namespace Interfaces
    {
        public interface IMedicamentos
        {
            bool InsereMedicamentoLista(Medicamento novoMedicamento);
            bool RemoverMedicamento(int codigo);
            bool LerMedicamento(string nomeFicheiro);
            bool GravarMedicamentos(string nomeFicheiro);
        }
    }

}
