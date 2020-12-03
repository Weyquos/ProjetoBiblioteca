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
    [Route("api/Livro")]
    [ApiController]
    public class LivroAPIController : ControllerBase
    {
        private readonly LivroDAO _livroDAO;
        public LivroAPIController(LivroDAO livroDAO)
        {
            _livroDAO = livroDAO;
        }

        // /api/Livro/Listar
        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            List<Livro> livro = _livroDAO.Listar();
            if (livro.Count > 0)
            {
                return Ok(new { livros = livro, msg = "Lista encontrada." });
            }
            return BadRequest(new { msg = "Essa pesquisa não retornou nenhum resultado." });
        }

        // /api/Livro/Buscar/id
        [HttpPost]
        [Route("Buscar/{id}")]
        public IActionResult Buscar(int id)
        {
            Livro livro = _livroDAO.BuscarPorId(id);
            if (livro != null)
            {
                return Ok(livro);
            }
            return BadRequest(new { msg = "Essa pesquisa não retornou nenhum resultado." });
        }

    }
}
