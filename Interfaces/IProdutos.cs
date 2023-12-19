/*
*	<copyright file="IProdutos" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 12/11/2023 13:22:45</date>
*	<description></description>
**/

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
