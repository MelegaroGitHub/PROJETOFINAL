using System;

namespace Hamburgueria_Tarde.Models
{
    public class Pedido 
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public Planos Planos {get;set;}
        public Contatos Contatos {get;set;}
        public DateTime DataPedido {get;set;}
        public double PrecoTotal {get;set;}

    }
}