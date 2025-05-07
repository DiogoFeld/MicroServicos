using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensageryLib
{
    public class OrderCreated
    {
        public OrderCreated(int id, int idPassado, int valor)
        {
            Id = id;
            IdPassado = idPassado;
            this.valor = valor;
        }

        public int Id { get; set; }
        public int IdPassado{ get; set; }
        public int valor{ get; set; }

    }
}
