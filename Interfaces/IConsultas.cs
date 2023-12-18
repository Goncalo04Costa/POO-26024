using System.Collections.Generic;
using ObjetosdeNegocio;
using Dados;

namespace Interfaces
{
    public interface IConsultas
    {
        int ContaConsultas();
        bool InsereConsultaLista(Consulta novoConsulta);
        bool LerConsultas(string nomeFicheiro);
        bool GravarConsultas(string nomeFicheiro);
        void OrdenarConsultasPorData();
    }
}
