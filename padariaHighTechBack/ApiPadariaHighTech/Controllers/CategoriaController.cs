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
    public class CategoriaController : Controller
    {
        public readonly PadariaHighTechDbContext _context;
        public CategoriaController()
        {
            _context = new PadariaHighTechDbContext();
        }
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return _context.Categorias;
        }

        [HttpPost]
        public void Post([FromBody] Categoria enviarCategoria)
        {
            _context.Categorias.Add(enviarCategoria);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Categoria categoriaParaDeletar = _context.Categorias.Find(id);
            _context.Remove(categoriaParaDeletar);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put([FromBody] Categoria editarCategoria)
        {
            Categoria EditarCategoria = _context.Categorias.Find();
            _context.Update(editarCategoria);
            _context.SaveChanges();
        }

    }
}
