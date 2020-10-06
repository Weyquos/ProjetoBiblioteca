using Microsoft.EntityFrameworkCore;
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

        public static bool Cadastrar(List<Livro> livros, int quantidade)
        {

            if (quantidade > 1)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    if (BuscarPorNome(livros[i].Nome) == null)
                    {
                        _context.Livros.AddRange(livros);

                    }

                    _context.SaveChanges();


                    return true;

                }
                if (quantidade == 1)
                {
                    _context.Livros.AddRange(livros);
                    _context.SaveChanges();
                    return true;
                }

            }
            return false;

        }

        public static List<Livro> BuscarPorCategoria(string nome) => _context.Livros.Include(x => x.Categoria).Where(x => x.Categoria.Nome.Equals(nome)).ToList();
        public static Livro BuscarPorNome(string nome) => _context.Livros.FirstOrDefault(x => x.Nome.Equals(nome));

        public static List<Livro> Listar() => _context.Livros.Include(x=> x.Categoria).ToList();

        public static List<Livro> ListarLivrosLocados() => _context.Livros.Include(x => x.Categoria).Where(x=> x.Status.Equals("Locado")).ToList();

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
