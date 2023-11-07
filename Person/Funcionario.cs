namespace Person
{
 public class Funcionario : Pessoa
{
    #region Atributos
    int codigo;
    DateTime dataentrada;
    string cargo;
    #endregion

    #region Metodos

    #region Construtores
    public Funcionario() 
    {
        codigo = 0;
        dataentrada = DateTime.Now;
        cargo = "";
    }

    public Funcionario(int codigo, DateTime dataentrada, string cargo) 
    {
        this.codigo = codigo;
        this.dataentrada = dataentrada;
        this.cargo = cargo;
    }

    #endregion

    #region Propriedades
    int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }
    DateTime DataEntrada
    {
        get { return dataentrada; }
        set { dataentrada = value; }
    }

    string Cargo
    {
        get { return cargo; } 
        set { cargo = value; }
    }
    #endregion

    #region Operadores
    public static bool operator ==(Funcionario f1, Funcionario f2)
    {
        if ((f1.Nome == f2.Nome) && (f1.Apelido == f2.Apelido) && (f1.Contacto == f2.Contacto) && (f1.Idade == f2.Idade) && (f1.Nif == f2.Nif) && (f1.Sns == f2.Sns) && (f1.codigo == f2.codigo))
            return true;
        return false;
    }

    public static bool operator !=(Funcionario f1, Funcionario f2)
    {

        if (f1 == f2)
            return false;
        return true;

    }
    #endregion

    #region Overrides
    public override string ToString()
    {
        return String.Format("Nome: {0} {1} - Idade: {2} - Contacto: {3} - NIF: {4} - SNS: {5} - Código: {6} - Data de Entrada: {7} - Cargo: {8}", Nome, Apelido, Idade.ToString(), Contacto.ToString(), Nif.ToString(), Sns.ToString(), codigo.ToString(), dataentrada.ToString("dd/MM/yyyy"), cargo);
    }


    public override bool Equals(object obj)
    {
        if (obj is Funcionario)
        {
            Funcionario f = (Funcionario)obj;
            if (this == f)
            {
                return true;
            }
        }
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    #endregion

    #region Destruidores
    #endregion

    #endregion


}
}