using ProjetoWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;

namespace ProjetoWPF.DAL
{
    class MovimentacaoDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static bool Cadastrar(Movimentacao movimentacao)
        {
            _context.Movimentacao.Add(movimentacao);
            _context.SaveChanges();
            return true;
        }

        public static List<Movimentacao> Listar() => _context.Movimentacao.ToList();

        //public static Movimentacao BuscarLinkCpfLivro(string nome, string cpf) => _context.Movimentacao.FirstOrDefault(x => x.Livro.Nome.Equals(nome) && x => x.Usuario.Cpf.Equals(cpf));

        public static Movimentacao BuscarPorId(int id) => _context.Movimentacao.Find(id);

        //Criar metódo que busca o CPF + nome do livro pra validar a entrega.
    }
}
