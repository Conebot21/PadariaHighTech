using Microsoft.EntityFrameworkCore;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Infra
{
    public class PadariaHighTechDbContext : DbContext
    {
        public PadariaHighTechDbContext() : base()
        {
        }

        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        //public virtual DbSet<Produto> Produtos { get; set; }
        //public virtual DbSet<Produto> Produtos { get; set; }
        //public virtual DbSet<Produto> Produtos { get; set; }
        //public virtual DbSet<Produto> Produtos { get; set; }

        //@"Server=<endereço/nome servidor>;Database=<nome database>;Trusted_Connection=True;"
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8O8S6E4\SQLEXPRESS;Database=PadariaHighTech;Trusted_Connection=True;");
        }
    }
}
