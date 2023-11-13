/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

// Declaração de um namespace chamado "Person"
namespace Person
{
    // Definição da classe Pessoa
    public class Pessoa
    {
        #region Atributos
        // Declaração dos atributos da classe
        string nome;
        string apelido;
        int idade;
        int NIF;
        int SNS;
        int contacto;
        #endregion

        #region Metodos

        #region Construtores
        // Construtor padrão da classe Pessoa
        public Pessoa()
        {
            nome = "";
            apelido = "";
            idade = 0;
            NIF = 0;
            SNS = 0;
            contacto = 0;
        }
        #endregion

        #region Propriedades
        // Propriedade Nome, com getter e setter
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Propriedade Apelido, com getter e setter
        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        // Propriedade Idade, com getter e setter
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        // Propriedade Nif, com getter e setter
        public int Nif
        {
            get { return NIF; }
            set { NIF = value; }
        }

        // Propriedade Sns, com getter e setter
        public int Sns
        {
            get { return SNS; }
            set { SNS = value; }
        }

        // Propriedade Contacto, com getter e setter
        public int Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        #endregion

        #region Operadores
        // Sobrecarga do operador de igualdade (==)
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            if ((p1.nome == p2.nome) && (p1.apelido == p2.apelido) && (p1.contacto == p2.contacto) && (p1.idade == p2.idade) && (p1.NIF == p2.NIF) && (p1.SNS == p2.SNS))
                return true;
            return false;
        }

        // Sobrecarga do operador de desigualdade (!=)
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            // Utiliza a sobrecarga do operador de igualdade para implementar o operador de desigualdade
            if (p1 == p2)
                return false;
            return true;
        }
        #endregion

        #region Overrides
        // Sobrescrita do método ToString
        public override string ToString()
        {
            // Retorna uma string formatada com informações sobre a pessoa
            return String.Format("Nome: {0}{1} - Idade: {2} - Contacto{3} - NIF:{4} - SNS:{5}", nome, apelido, idade.ToString(), contacto.ToString(), NIF.ToString(), SNS.ToString());
        }

        // Sobrescrita do método Equals
        public override bool Equals(object obj)
        {
            // Verifica se o objeto é do tipo Pessoa e se é igual à instância atual usando o operador de igualdade sobrecarregado
            if (obj is Pessoa)
            {
                Pessoa p = (Pessoa)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }

        // Sobrescrita do método GetHashCode
        public override int GetHashCode()
        {
            // Retorna o código hash padrão da classe base
            return base.GetHashCode();
        }
        #endregion

        #region Destruidores
        // Não há destruidores definidos neste exemplo
        #endregion

        #endregion
    }
}
