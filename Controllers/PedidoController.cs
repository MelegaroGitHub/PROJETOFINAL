using Hamburgueria_Tarde.Models;
using Hamburgueria_Tarde.Repositorios;
using Hamburgueria_Tarde.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria_Tarde.Controllers
{
    public class PedidoController : Controller
   {

       private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
       private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository Repositorio = new PedidoRepository();

        private PlanosRepositorio planosRepositorio = new PlanosRepositorio();

        private ContatosRepositorio contatosRepositorio = new ContatosRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            var planos = planosRepositorio.Listar();
            var cliente = clienteRepository.ObterPor(HttpContext.Session.GetString(SESSION_EMAIL));

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Planos = planos;
            

            pedido.Cliente = cliente == null ? new Cliente() : cliente;
            

            return View(pedido);
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);

            Pedido pedido = new Pedido();

            // Forma 1 - Mais comum
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;

            // Forma 2 - Usa parâmetros nos construtores
            Planos plano = new Planos(
                Nome: form["Planos"],
                Preco: planosRepositorio.ObterPrecoDe(form["Planos"])
            );
    
            pedido.Planos = plano;

            // Forma 3 - Resumo da Forma 1
            Contatos contato = new Contatos() {
                Nome = form["shake"],
            };

            pedido.Contatos = contato;

            pedido.PrecoTotal = pedido.Planos.Preco + pedido.Contatos.Preco;

            Repositorio.Inserir(pedido);
            ViewData["NomeView"] = "Pedido";
            
            return View("Sucesso");
        }

    }
}