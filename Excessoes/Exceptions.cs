using System;

namespace Excecao
{
  

    

    //----------------------------------------------------------------------------------//



 
    /// <summary>
    /// Exceção para escrita de ficheiro.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiro : Exception
    {
        public EscritaFicheiro() { }

        public EscritaFicheiro(string message) : base(message) { }
    }

   



    //----------------------------------------------------------------------------------//

    /// <summary>
    /// Exceção para leitura de Ficheiro.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class LeituraFicheiroException : Exception
    {
        public LeituraFicheiroException(string message) : base(message) { }
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
    /// Exceção genérica para Produto de limpeza.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class LimpezaException : Exception
    {
        public LimpezaException() { }

        public LimpezaException(string message) : base(message) { }
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





    


    //-----------------------//


    /// <summary>
    /// Exceção oara utentes sem contacto familiar
    /// </summary>
    public class SemContactoFamiliarException : Exception
    {
        public SemContactoFamiliarException() { }

        public SemContactoFamiliarException(string message) : base(message) { }
    }
}
