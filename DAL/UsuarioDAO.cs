using ProjetoWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoWPF.DAL
{
    class UsuarioDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static bool Cadastrar(Usuario usuario)
        {
            if (BuscarPorEmail(usuario.Email) == null)
            {
                if (BuscarPorCpf(usuario.Cpf) == null)
                {
                    _context.Usuarios.Add(usuario);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            return false;
        }
        public static List<Usuario> Listar() => _context.Usuarios.ToList();

        public static Usuario BuscarPorId(int id) => _context.Usuarios.Find(id);

        public static Usuario BuscarPorCpf(string cpf) => _context.Usuarios.FirstOrDefault(x => x.Cpf.Equals(cpf));
        public static Usuario BuscarPorEmail(string email) => _context.Usuarios.FirstOrDefault(x => x.Email.Equals(email));
        public static void AlterarDados(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }
        public static void RemoverUsuario(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            
            try
            {
                _context.SaveChanges();
            }
            catch (Exception Error)
            {
                throw;
            }
        }

    }
}
