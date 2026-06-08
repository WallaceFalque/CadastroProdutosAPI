using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosServices ps;

        public ProdutosController(IProdutosServices produtoService)
        {
            ps = produtoService;
        }

        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            return Ok(ps.ObterTodos());

        }

        [HttpGet("{id}")]
        public ActionResult<Produto> GetById(int id)
        {
            var prod = ps.ObterPorId(id);
            return prod is null ? NotFound() : Ok(prod);
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            var prod = ps.CadastrarProduto(produto);
            return prod is null ? BadRequest() : Created();
        }

        [HttpPut("{id}")]
        public ActionResult<Produto> Edit(Produto produto, int id)
        {
            var editProd = ps.EditarProduto(produto, id);
            return editProd is null ? BadRequest() : Ok(produto);
        }

        [HttpDelete("{id}")]
        public ActionResult Deletar(int id)
        {
            return ps.DeletarProduto(id) ? NoContent() : NotFound();
        }

    }
}