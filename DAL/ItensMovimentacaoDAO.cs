using ProjetoWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoWPF.DAL
{
    class ItensMovimentacaoDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static bool Cadastrar(ItensMovimentacao itensmovimentacao)
        {
            _context.ItensMovimentacao.Add(itensmovimentacao);
            _context.SaveChanges();
            return true;
        }

        public static List<ItensMovimentacao> Listar() => _context.ItensMovimentacao.ToList();

        public static ItensMovimentacao BuscarPorId(int id) => _context.ItensMovimentacao.Find(id);
    }
}
