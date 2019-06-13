using System.Collections.Generic;
using Hamburgueria_Tarde.Models;

namespace Hamburgueria_Tarde.ViewModels
{
    public class PedidoViewModel
    {
        public List<Planos> Planos {get;set;}
        public List<Contatos> Contatos {get;set;}
        public Cliente Cliente {get;set;}
    }
}