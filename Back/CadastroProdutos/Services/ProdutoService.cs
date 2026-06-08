using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroProdutos.Services
{
    public class ProdutoService : IProdutosServices
    {
        static private List<Produto> produtos = new List<Produto>()
    {
        new Produto () {Id = 1 ,Nome = "Mouse", Preco = 250, Estoque = 4},
        new Produto () {Id = 2, Nome = "Teclado", Preco = 352, Estoque = 2}
    };

        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto? ObterPorId(int id)
        {
            return produtos.FirstOrDefault(c => c.Id == id);
        }

        public Produto CadastrarProduto(Produto produto)
        {
            produtos.Add(produto);
            return produto;
        }

        public Produto? EditarProduto(Produto produto, int id)
        {
            var prod = produtos.FirstOrDefault(c => c.Id == id);

            prod?.Nome = produto.Nome;
            prod?.Preco = produto.Preco;
            prod?.Estoque = produto.Estoque;

            return prod;
        }

        public bool DeletarProduto(int id)
        {
            var index = produtos.FindIndex(c => c.Id == id);
            if (index == -1) { return false; }
            produtos.RemoveAt(index);
            return true;
        }
    }
}