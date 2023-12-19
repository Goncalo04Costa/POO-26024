/*
*	<copyright file="IMedicamentos" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 12/11/2023 13:23:21</date>
*	<description></description>
**/

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
