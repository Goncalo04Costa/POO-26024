/*
*	<copyright file="IFuncionarios" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 12/11/2023 13:26:28</date>
*	<description></description>
**/

using ObjetosdeNegocio;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IFuncionario
    {
        bool InsereAuxiliarLista(Auxiliar novoAuxiliar);
        bool InsereEnfermeiroLista(Enfermeiro novoEnfermeiro);
        bool InsereMedicoLista(Medico novoMedico);
        bool ExisteMedico(int codigoMedico);
        bool ExisteEnfermeiro(int codigoEnfermeiro);
        bool ExisteAuxiliar(int codigoAuxiliar);
        bool RemoverMedico(int codigoMedico);
        bool RemoveEnfermeiro(int codigoEnfermeiro);
        bool RemoverAuxiliar(int codigoAuxiliar);
        bool GravarFuncionarios(string nomeFicheiro);
        bool GravarEnfermeiros(string nomeFicheiro);
        bool GravarAuxiliares(string nomeFicheiro);
        bool LerMedicos(string nomeFicheiro);
        bool LerEnfermeiros(string nomeFicheiro);
        bool LerAuxiliares(string nomeFicheiro);
        List<Auxiliar> EnviarTodosAuxiliares();
        int ContaAuxiliares();
        List<Enfermeiro> EnviarTodosEnfermeiros();
        int ContaEnfermeiros();
        List<Medico> ListarMedicos();
        int ContarMedicos();
    }
}
