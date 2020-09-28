using ProjetoWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoWPF.DAL
{
    class LivroDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static bool Cadastrar(Livro livro)
        {
            if(BuscarPorNome(livro.Nome) == null)
            {
                _context.Livros.Add(livro);
                _context.SaveChanges();
                return true;
            }
            return false;
            
        }

        public static Livro BuscarPorNome(string nome) => _context.Livros.FirstOrDefault(x => x.Nome.Equals(nome));

        public static List<Livro> Listar() => _context.Livros.ToList();

        public static Livro BuscarPorId(int id) => _context.Livros.Find(id);
        public static void AlterarDados(Livro livro)
        {
            _context.Livros.Update(livro);
            _context.SaveChanges();
        }
        public static void RemoverLivro(Livro livro)
        {
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }
    }
}
