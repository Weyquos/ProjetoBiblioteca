using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoWPF.Models
{
    [Table("ItensMovimentacao")]
    class ItensMovimentacao : BaseModel
    {
        public ItensMovimentacao()
        {
            LocadoEm = DateTime.Now;
            Livro = new Livro();
        }
        public Livro Livro { get; set; }
        public DateTime LocadoEm { get; set; } //quando o adm clicar em "locar" no botão, gravar a data/hora que o livro foi locado

    }
}
