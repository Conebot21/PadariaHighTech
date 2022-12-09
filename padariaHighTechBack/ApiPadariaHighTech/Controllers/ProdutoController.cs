using Microsoft.AspNetCore.Mvc;
using Negocio.Entidades;
using Negocio.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPadariaHighTech.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        public readonly PadariaHighTechDbContext _context;
        public ProdutoController()
        {
            _context = new PadariaHighTechDbContext();
        }
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _context.Produtos;
        }

        [HttpPost]
        public void Post([FromBody] Produto enviarProduto){
            _context.Produtos.Add(enviarProduto);
            _context.SaveChanges();
            }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Produto produtoParaDeletar = _context.Produtos.Find(id);
            _context.Remove(produtoParaDeletar);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Produto peditarProduto)
        {
            Produto produtoParaEditar = _context.Produtos.Find(id);
            _context.Update(produtoParaEditar);
            _context.SaveChanges();
        }
    }
}
