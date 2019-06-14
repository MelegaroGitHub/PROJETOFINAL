using System;
using Hamburgueria_Tarde.Models;
using Hamburgueria_Tarde.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJETOFINAL.Models;
using PROJETOFINAL.Repositorios;

namespace Hamburgueria_Tarde.Controllers
{
    public class CadastroController : Controller
    {
        private RegistroRepositorio registroRepositorio = new RegistroRepositorio();
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);
            
            clienteRepository.Inserir(cliente);

            ViewData["Action"] = "Cadastro";
            return View("Sucesso");

        }
    }
}