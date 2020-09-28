using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoWPF.Models
{
    [Table("Usuarios")]
    class Usuario : BaseModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string LivroPosse { get; set; }

        public override string ToString() => $"Nome: {Nome} | CPF: {Cpf} | E-mail: {Email} ";
    }
}
