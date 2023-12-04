using System.Collections.Generic;
using ObjetosdeNegocio;

namespace Interfaces
{
    public interface IProdutos
    {
        bool InsereProdutoLista(Produto novoProduto);
        bool ExisteFuncionario(int codigo);
        bool RemoveProd(int codigo);
        List<Produto> ListarProdutos();
        int ContarProdutos();
    }
}
