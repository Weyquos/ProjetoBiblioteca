using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoWPF.Models
{
    [Table("Movimentacao")]
    class Movimentacao : BaseModel
    {
        public Movimentacao()
        {
            LocadoEm = DateTime.Now;
            Livro = new List<Livro>();
            Usuario = new List<Usuario>();
        }
        public DateTime LocadoEm { get; set; } //quando o adm clicar em "locar" no botão, gravar a data/hora que o livro foi locado
        public List<Livro> Livro { get; set; }
        public List<Usuario> Usuario { get; set; }
    }
}
