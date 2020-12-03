using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoWeb.DAL;
using ProjetoWeb.Models;

namespace ProjetoWeb.Controllers
{
    [Authorize]
    //[Authorize(Roles = "ADM")]
    public class CategoriaController : Controller
    {
        private readonly CategoriaDAO _categoriaDAO;
        public CategoriaController(CategoriaDAO categoriaDAO) => _categoriaDAO = categoriaDAO;

        public IActionResult Index()
        {
            return View(_categoriaDAO.Listar());
        }
        
        public IActionResult Cadastrar() => View();

        [HttpPost]
        public IActionResult Cadastrar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (_categoriaDAO.Cadastrar(categoria))
                {
                    return RedirectToAction("Index", "Categoria");
                }
                ModelState.AddModelError("", "Já existe uma categoria cadastrada com esse nome.");              
            }
            return View(categoria);
        }

        public IActionResult Remover(int id)
        {
            _categoriaDAO.Remover(id);
            return RedirectToAction("Index", "Categoria");
        }

        public IActionResult Alterar(int id)
        {     
            return View(_categoriaDAO.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Alterar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaDAO.Alterar(categoria);
                return RedirectToAction("Index", "Categoria");
            }
            return View(categoria);
        }
        
    }
}
