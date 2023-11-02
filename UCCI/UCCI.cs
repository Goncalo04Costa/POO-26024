using System;
using DIRETOR;
using UTENTE;
using FUNCIONARIO;
using PESSOA;

namespace UCCI
{
    public class UCCI
    {
        #region Atributos
        string nome;
        int capacidade;
        Utente[] utentes;
        Funcionario[] funcionarios;
        Diretor[] diretores;
        #endregion
        #region Metodos

        #region Construtores
        public UCCI()
        {
            nome = "";
            capacidade = 0;
        }
        
        public UCCI(string nome, int capacidade)
        {
            this.nome = nome;
            this.capacidade = capacidade;
    
        }
        #endregion

        #region Propriedades
        #endregion

        #region Operadores
        #endregion

        #region Overrides
        #endregion

        #region Destruidores
        #endregion

        #endregion


    }
}