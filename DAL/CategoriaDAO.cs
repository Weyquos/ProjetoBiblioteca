using ProjetoWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoWPF.DAL
{
    class CategoriaDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static bool Cadastrar(Categoria categoria)
        {
            if (BuscarPorNomeParaCadastro(categoria.Nome) == null)
            {
                _context.Categorias.Add(categoria);
                _context.SaveChanges();
                return true;
            }
            return false;

        }

        public static Categoria BuscarPorNomeParaCadastro(string nome) => _context.Categorias.FirstOrDefault(x => x.Nome.Equals(nome));

        public static List<Categoria> Listar() => _context.Categorias.ToList();

        public static Categoria BuscarPorId(int id) => _context.Categorias.Find(id);
        public static List<Categoria> BuscarPorNome(string nome) => _context.Categorias.Where(x => x.Nome.Contains(nome)).ToList();
        public static void AlterarDados(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            _context.SaveChanges();
        }
        public static void RemoverCategoria(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
        }
    }
}
