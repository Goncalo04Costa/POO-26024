/*
*	<copyright file="UnitTest01" company="IPCA">
*	</copyright>
* 	<author>Gonçalo Costa</author>
*	<contact>a26024@alunos.ipca.pt</contact>
*   <date>2023 16/12/2023 12:34:23</date>
*	<description></description>
**/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dados;
using ObjetosdeNegocio;

namespace TesteUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsereAuxiliar()
        {
        Auxiliar auxiliar1 = new Auxiliar(234, "21/11/2022", "Piso1", 123456789, 1001, "Funcional", "Jose", "Pedro", 30, 123456789, 924070650);
        Auxiliar auxiliar2 = new Auxiliar(234, "21/11/2022", "Piso1", 123456789, 1001, "Funcional", "Jose", "Pedro", 30, 123456789, 924070650);
        Auxiliar auxiliar3 = new Auxiliar(234, "21/11/2022", "Piso1", 123456789, 1001, "Funcional", "Jose", "Pedro", 30, 123456789, 924070650);
        Auxiliar auxiliar4 = new Auxiliar(234, "21/11/2022", "Piso1", 123456789, 1001, "Funcional", "Jose", "Pedro", 30, 123456789, 924070650);
        Auxiliar copiaAuxiliar1 = auxiliar1;
            bool resultado;
            try
            {
                
                bool resultado1 = Funcionarios.InsereAuxiliarLista(auxiliar1);
                bool resultado2 = Funcionarios.InsereAuxiliarLista(auxiliar2);
                bool resultado3 = Funcionarios.InsereAuxiliarLista(auxiliar3);
                bool resultado4 = Funcionarios.InsereAuxiliarLista(auxiliar4);
                bool resultadoCopia = Funcionarios.InsereAuxiliarLista(copiaAuxiliar1); 

               
                Assert.IsTrue(resultado1);
                Assert.IsTrue(resultado2);
                Assert.IsTrue(resultado3);
                Assert.IsTrue(resultado4);
                Assert.IsFalse(resultadoCopia); 

                bool remocao = Funcionarios.RemoverAuxiliares();

             
                Assert.IsTrue(remocao);
            }
            catch (Exception)
            {
                Assert.Fail("ERRO");
            }
        }


        [TestMethod]
        public void InsereUtente()
        {
            Utente utente1 = new Utente(924070650, new DateTime(2023,2,20), "Estavel", 1, "Joao", "Ferreira", 65, 123456789, 1001);
            Utente utente2 = new Utente(924070650, new DateTime(2023, 2, 20), "Estavel", 1, "Joao", "Ferreira", 65, 123456789, 1001);
            Utente utente3 = new Utente(924070650, new DateTime(2023, 2, 20), "Estavel", 1, "Joao", "Ferreira", 65, 123456789, 1001);
            Utente utente4 = new Utente(924070650, new DateTime(2023, 2, 20), "Estavel", 1, "Joao", "Ferreira", 65, 123456789, 1001);
            Utente copiaUtente1 = utente1;
            bool resultado;
            try
            {
                bool resultado1 = Utentes.InsereUtenteLista(utente1);
                bool resultado2 = Utentes.InsereUtenteLista(utente2);
                bool resultado3 = Utentes.InsereUtenteLista(utente3);
                bool resultado4 = Utentes.InsereUtenteLista(utente4);
                bool copiaresultado1 = Utentes.InsereUtenteLista(copiaUtente1);

                bool remocao = Utentes.RemoverUtentes();

                Assert.IsTrue(remocao);
            }
            catch (Exception ) 
            {
            Assert.Fail("ERRO");
            }
        }


        public void InsereConsultas()
        {
            Consulta consulta1 = new Consulta(1,  new DateTime(2023, 12, 21), 123456789, 987654321, "Hospital Regional", 20 );
            Consulta consulta2 = new Consulta(1, new DateTime(2023, 12, 21), 123456789, 987654321, "Hospital Regional", 20);
            Consulta consulta3 = new Consulta(1, new DateTime(2023, 12, 21), 123456789, 987654321, "Hospital Regional", 20);
            Consulta consulta4 = new Consulta(1, new DateTime(2023, 12, 21), 123456789, 987654321, "Hospital Regional", 20);
            Consulta copiaConsulta1 = consulta1;

            bool resultado;
            try
            {
                bool resultado1 = Consultas.InsereConsultaLista(consulta1);
                bool resultado2 = Consultas.InsereConsultaLista(consulta2);
                bool resultado3 = Consultas.InsereConsultaLista(consulta3);
                bool resultado4 = Consultas.InsereConsultaLista(consulta4);
                bool copiaresultado1 = Consultas.InsereConsultaLista(copiaConsulta1);

                bool remocao = Consultas.RemoverConsultas();

                Assert.IsTrue(remocao);
            }
            catch (Exception)
            {
                Assert.Fail("ERRO");
            }
        }

    }
}
