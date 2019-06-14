using System;

namespace PROJETOFINAL.Models
{
    public class RegistroModel
    {
        public int Id{get;set;}
        public string Nome{get;set;}
        public string Sobrenome{get;set;}
        public string Email{get;set;}
        public string Mensagem{get;set;}
        public DateTime DataEntrada{get;set;}
    }
}