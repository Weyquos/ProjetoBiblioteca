using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoWPF.Models
{
    [Table("Livros")]
    class Livro : BaseModel
    {
        public Livro()
        {
            Status = "Disponivel";
            LocadoEm = DateTime.Now;
            Categoria = new List<Categoria>();
        }
        public List<Categoria> Categoria { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public int Quantidade { get; set; } //caso seja X itens (qualquer número >1), clonar os dados e criar X vezes o mesmo livro com a quantidade 1
        public string Status { get; set; } //disponivel -- locado
        public DateTime LocadoEm { get; set; } //quando o adm clicar em "locar" no botão, gravar a data/hora que o livro foi locado

        public override string ToString() => $"Nome: {Nome} | Autor: {Autor} | Ano de Publicação: {AnoPublicacao} | Editora: {Editora} | Status: {Status}  ";
    }
}
