using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoWeb.DAL;
using ProjetoWeb.Models;

namespace ProjetoWeb.Controllers
{
    [Route("api/Categoria")]
    [ApiController]
    public class CategoriaAPIController : ControllerBase
    {
        private readonly CategoriaDAO _categoriaDAO;
        public CategoriaAPIController(CategoriaDAO categoriaDAO)
        {
            _categoriaDAO = categoriaDAO;
        }

        // /api/Categoria/Listar
        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            List<Categoria> categoria = _categoriaDAO.Listar();
            if (categoria.Count > 0)
            {
                return Ok(new { categorias = categoria, msg = "Lista encontrada." });
            }
            return BadRequest(new { msg = "Essa pesquisa não retornou nenhum resultado." });
        }

        // /api/Categoria/Buscar/id
        [HttpPost]
        [Route("Buscar/{id}")]
        public IActionResult Buscar(int id)
        {
            Categoria categoria = _categoriaDAO.BuscarPorId(id);
            if (categoria != null)
            {
                return Ok(categoria);
            }
            return BadRequest(new { msg = "Essa pesquisa não retornou nenhum resultado." });
        }
    }
}
