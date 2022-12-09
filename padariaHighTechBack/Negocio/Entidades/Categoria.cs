using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negocio.Entidades
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
    }
}
