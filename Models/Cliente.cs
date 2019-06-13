using System;
using System.ComponentModel;
namespace Hamburgueria_Tarde.Models
{
    public class Cliente
    {
        public ulong Id {get;set;}
        public string Nome {get;set;}
        public string Sobrenome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataNascimento { get; set; }
        public string Tipo{get;set;}
    }
}