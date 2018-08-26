using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoriasAlura
{
    public class Compra
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Mercadorias Mercadorias { get; set; }
        public int MercadoriaId { get; set; }

    }
}
