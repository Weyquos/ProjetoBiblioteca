using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoWeb.DAL;
using ProjetoWeb.Models;
using ProjetoWeb.Utils;

namespace ProjetoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly LivroDAO _livroDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly ItemAlugadoDAO _itemAlugadoDAO;
        private readonly Sessao _sessao;
        public HomeController(LivroDAO livroDAO, CategoriaDAO categoriaDAO, ItemAlugadoDAO itemAlugadoDAO, Sessao sessao)
        {
            _categoriaDAO = categoriaDAO;
            _livroDAO = livroDAO;
            _itemAlugadoDAO = itemAlugadoDAO;
            _sessao = sessao;
        }
        public IActionResult Index(int id)
        {
            ViewBag.Categorias = _categoriaDAO.Listar();
            if (id == 0)
            {
                return View(_livroDAO.Listar());
            }
            return View(_livroDAO.ListarPorCategoria(id));
        }

        public IActionResult AdicionarAoCarrinho(int id)
        {
            Livro livro = _livroDAO.BuscarPorId(id);
            ItemAlugado item = new ItemAlugado
            {
                Livro = livro,
                Quantidade = 1,
                CarrinhoId = _sessao.BuscarCarrinhoId()
            };
            _itemAlugadoDAO.Cadastrar(item);
            return RedirectToAction("CarrinhoAlugueis");
        }

        public IActionResult CarrinhoAlugueis()
        {
            string carrinhoId = _sessao.BuscarCarrinhoId();
            return View(_itemAlugadoDAO.ListarPorCarrinhoId(carrinhoId));
        }
        /* Adicionar na função a parte de puxar os itens alugados */
        [Authorize]
        public IActionResult MeusLivros()
        {
            return View(_livroDAO.ListarLivrosLocados());
        }
        
        public IActionResult Remover(int id)
        {
            _itemAlugadoDAO.Remover(id);
            return RedirectToAction("CarrinhoAlugueis", "Home");
        }
    }
}
