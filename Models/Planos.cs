using Microsoft.Extensions.Primitives;

namespace Hamburgueria_Tarde.Models
{
    public class Planos : Produto
    {
        public Planos()
        {
        }

        public Planos(StringValues Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }

        
    }
}