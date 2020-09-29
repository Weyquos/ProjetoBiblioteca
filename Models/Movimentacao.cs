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
            Usuario = new Usuario();
            ItensMovimentacao = new List<ItensMovimentacao>();
        }
        public Usuario Usuario { get; set; }
        public List<ItensMovimentacao> ItensMovimentacao { get; set; }
    }
}
