using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoWPF.Models
{
    [Table("Categorias")]
    class Categoria : BaseModel
    {
        public string Nome { get; set; }
        public override string ToString() => $"{Nome}";

    }
}
