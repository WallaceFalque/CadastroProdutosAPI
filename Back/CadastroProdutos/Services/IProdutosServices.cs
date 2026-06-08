using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroProdutos.Services
{
    public interface IProdutosServices
    {
        public List<Produto> ObterTodos();
        public Produto? ObterPorId(int id);
        public Produto CadastrarProduto(Produto produto);
        public Produto? EditarProduto(Produto produto, int id);
        public bool DeletarProduto(int id);
    }
}