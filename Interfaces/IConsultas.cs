/*
*	<copyright file="IConsultas" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 12/11/2023 13:28:45</date>
*	<description></description>
**/

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
