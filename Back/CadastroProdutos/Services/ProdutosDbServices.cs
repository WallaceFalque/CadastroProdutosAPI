using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Database;
using Microsoft.EntityFrameworkCore;

namespace CadastroProdutos.Services
{
    public class ProdutosDbServices : IProdutosServices
    {
        private ApplicationDbContext context;

        public ProdutosDbServices (ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        public Produto CadastrarProduto(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
            return produto;            
        }

        public bool DeletarProduto(int id)
        {
            var prod = context.Produtos.FirstOrDefault(c => c.Id == id);

            if (prod is null) {return false;}

            context.Produtos.Remove(prod);
            context.SaveChanges();

            return true;
        }

        public Produto? EditarProduto(Produto produto, int id)
        {
           var prod = context.Produtos.FirstOrDefault(c => c.Id == id);

           if (prod is null) {return null;}

           prod.Nome = produto.Nome;
           prod.Preco = produto.Preco;
           prod.Estoque = produto.Estoque;

           context.SaveChanges();
           return prod;
        }

        public Produto? ObterPorId(int id)
        {
            return context.Produtos.FirstOrDefault(c => c.Id == id);
        }

        public List<Produto> ObterTodos()
        {
            return context.Produtos.ToList();
        }
    }
}