﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoWeb.Models;

namespace ProjetoWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Context _context;
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public UsuarioController(Context context, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {            
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Usuario

        [Authorize]
        //[Authorize(Roles = "ADM")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Senha,Id,CriadoEm,ConfirmacaoSenha,Cep,Cidade,Bairro,Logradouro,TipoLogradouro,Uf")] UsuarioView usuarioView)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario
                {
                    UserName = usuarioView.Email,
                    Email = usuarioView.Email,
                    Cep = usuarioView.Cep,
                    Cidade = usuarioView.Cidade,
                    Logradouro = usuarioView.Logradouro,
                    TipoLogradouro = usuarioView.TipoLogradouro,
                    Bairro = usuarioView.Bairro,
                    Uf = usuarioView.Uf

                };
                IdentityResult resultado = await _userManager.CreateAsync(usuario, usuarioView.Senha);
                if(resultado.Succeeded)
                {
                    _context.Add(usuarioView);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                AdicionarErros(resultado);
            }
            return View(usuarioView);
        }

        public void AdicionarErros(IdentityResult resultado)
        {
            foreach (IdentityError erro in resultado.Errors)
            {
                ModelState.AddModelError("", erro.Description);
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha")]UsuarioView usuarioView)
        {
            var result = await _signInManager.PasswordSignInAsync(usuarioView.Email, usuarioView.Senha, false, false);
            var name = User.Identity.Name;
            if(result.Succeeded)
            {
                return RedirectToAction("CarrinhoAlugueis", "Home");
            }
            ModelState.AddModelError("", "Email ou senha incorretos.");
            return View(usuarioView);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}
