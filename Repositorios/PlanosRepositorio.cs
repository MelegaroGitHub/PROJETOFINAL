using System.IO;
using System.Collections.Generic;
using Hamburgueria_Tarde.Models;

namespace Hamburgueria_Tarde.Repositorios
{
    public class PlanosRepositorio
    {
        private const string PATH = "Database/Planos.csv";

        private List<Planos> planos = new List<Planos>();

        public List<Planos> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Planos plano = new Planos();
                plano.Nome = valores[0];
                plano.Preco = double.Parse(valores[1]);

                planos.Add(plano);
            }

            return planos;
        }

        public double ObterPrecoDe(string nomePlanos) 
        {
            var lista = Listar();
            var preco = 0.0;

            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomePlanos))
                {
                    preco = item.Preco;
                }
            }

            return preco;
        }
    }
}