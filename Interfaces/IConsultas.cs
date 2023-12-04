using System.Collections.Generic;
using ObjetosdeNegocio;
using Dados;

namespace Interfaces
{
    public interface IConsultas
    {

        public  bool InsereConsultaLista(Consulta novoConsulta);
        public bool LerConsultas(string nomeFicheiro);
        public bool GravarConsultas(string nomeFicheiro);
        public bool VerificarContactoFamiliarPorSNS(int snsConsulta, Utentes listaDeUtentes);
    }
}
