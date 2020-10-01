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
            Categoria = new Categoria();
        }
        public Categoria Categoria { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public string Status { get; set; } //disponivel -- locado
        public override string ToString() => $"Nome: {Nome} | Autor: {Autor} | Ano de Publicação: {AnoPublicacao} | Editora: {Editora} ";
    }
}
