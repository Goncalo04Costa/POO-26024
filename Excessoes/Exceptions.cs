using System;

namespace Excecao
{
    /// <summary>
    /// Exceção para verificação de existência de cliente.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class UtenteNaoExisteException : Exception
    {
        public UtenteNaoExisteException(string message) : base(message)
        { }
    }


    /// <summary>
    /// Exceção para verificação de existência de produto.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ProdutoNaoExisteException : Exception
    {
        public ProdutoNaoExisteException(string message) : base(message)
        { }
    }

    /// <summary>
    /// Exceção para verificação de existência de medicamento.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MedicamentoNaoExisteException : Exception
    {
        public MedicamentoNaoExisteException(string message) : base(message)
        { }
    }

    /// <summary>
    /// Exceção para verificação de existência de auxiliar.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class AuxiliarNaoExisteException : Exception
    {
        public AuxiliarNaoExisteException(string message) : base(message)
        { }
    }

    /// <summary>
    /// Exceção para verificação de existência de enfermeiro.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EnfermeiroNaoExisteException : Exception
    {
        public EnfermeiroNaoExisteException(string message) : base(message)
        { }
    }

    /// <summary>
    /// Exceção para verificação de existência de médico.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MedicoNaoExisteException : Exception
    {
        public MedicoNaoExisteException(string message) : base(message)
        { }
    }

    /// <summary>
    /// Exceção para verificação de existência de funcionário.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class FuncionarioNaoExisteException : Exception
    {
        public FuncionarioNaoExisteException(string message) : base(message)
        { }
    }

    /// <summary>
    /// Exceção  para verificar existencia de consulta
    /// </summary>
    public class ConsultaNaoExisteException : Exception
    {
        public ConsultaNaoExisteException(string message) : base(message)
        { }
    }

    //----------------------------------------------------------------------------------//



    /// <summary>
    /// Exceção para escrita de Utentes.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiroUtenteException : Exception
    {
        public EscritaFicheiroUtenteException() { }

        public EscritaFicheiroUtenteException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção para escrita de produtos.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaficheiroProdutoException : Exception
    {
        public EscritaficheiroProdutoException() { }

        public EscritaficheiroProdutoException(string message) : base(message) { }
    }



    /// <summary>
    /// Exceção para escrita de Medicamentos.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiroMedicamentoException : Exception
    {
        public EscritaFicheiroMedicamentoException() { }

        public EscritaFicheiroMedicamentoException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção para escrita de Auxiliares.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiroAuxiliaresException : Exception
    {
        public EscritaFicheiroAuxiliaresException() { }

        public EscritaFicheiroAuxiliaresException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção para escrita de Enfermeiros.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiroEnfermeirosException : Exception
    {
        public EscritaFicheiroEnfermeirosException() { }

        public EscritaFicheiroEnfermeirosException(string message) : base(message) { }
    }
   



  

    /// <summary>
    /// Exceção para escrita de Médicos.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiroMedicosException : Exception
    {
        public EscritaFicheiroMedicosException() { }

        public EscritaFicheiroMedicosException(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção para escrita de Funcionários.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiroFuncionariosException : Exception
    {
        public EscritaFicheiroFuncionariosException() { }

        public EscritaFicheiroFuncionariosException(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção para escrita de Consultas.
    /// </summary>

    public class EscritaFicheiroConsultasException : Exception
    {
        public EscritaFicheiroConsultasException() { }

        public EscritaFicheiroConsultasException(string message) : base(message) { }
    }



    //----------------------------------------------------------------------------------//

    /// <summary>
    /// Exceção para leitura de Utentes.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class LeituraFicheiroUtenteException : Exception
    {
        public LeituraFicheiroUtenteException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção para leiura de Produtos
    /// </summary>
    public class LeituraficheiroProdutoException : Exception
    {
        public LeituraficheiroProdutoException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção parra leitura de Medicamentos
    /// </summary>
    public class LeituraFicheiroMedicamentoException : Exception
    {
        public LeituraFicheiroMedicamentoException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção parra leitura de Auxiliares
    /// </summary>
    public class LeituraFicheiroAuxiliarException : Exception
    {
        public LeituraFicheiroAuxiliarException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção parra leitura de Enfermeiros
    /// </summary>
    public class LeituraFicheiroEnfermeiroException : Exception
    {
        public LeituraFicheiroEnfermeiroException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção parra leitura de Medicos
    /// </summary>
    public class LeituraFicheiroMedicoException : Exception
    {
        public LeituraFicheiroMedicoException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção parra leitura de Consultas
    /// </summary>
    public class LeituraFicheiroConsultaException : Exception
    {
        public LeituraFicheiroConsultaException(string message) : base(message) { }
    }



    /// <summary>
    /// Exceção parra leitura de Funcionarios
    /// </summary>
    public class LeituraFicheiroFuncionarioException : Exception
    {
        public LeituraFicheiroFuncionarioException(string message) : base(message) { }
    }


    //----------------------------------------------------------------------------------//


    /// <summary>
    /// Exceção genérica para Utentes.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class UtenteException : Exception
    {
        public UtenteException() { }

        public UtenteException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção genérica para Produto.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ProdutoException : Exception
    {
        public ProdutoException() { }

        public ProdutoException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção genérica para Medicamento.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MedicamentoException : Exception
    {
        public MedicamentoException() { }

        public MedicamentoException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção genérica para Auxiliares.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class AuxiliarException : Exception
    {
        public AuxiliarException() { }

        public AuxiliarException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção genérica para Enfermeiros.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EnfermeiroException : Exception
    {
        public EnfermeiroException() { }

        public EnfermeiroException(string message) : base(message) { }
    }

 

    /// <summary>
    /// Exceção genérica para Médicos.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MedicoException : Exception
    {
        public MedicoException() { }

        public MedicoException(string message) : base(message) { }
    }


    /// <summary>
    /// Exceção genérica para Consultas.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ConsultaException : Exception
    {
        public ConsultaException() { }

        public ConsultaException(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção genérica para Funcionários.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class FuncionarioException : Exception
    {
        public FuncionarioException() { }

        public FuncionarioException(string message) : base(message) { }
    }
  
}
