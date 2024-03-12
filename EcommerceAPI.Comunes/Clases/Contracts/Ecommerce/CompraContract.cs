using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Clases.Contracts.Ecommerce
{
    public class CompraContract
    {
        public int id_compra { get; set; }
        public DateTime fecha { get; set; }
        public double valortotal { get; set; }
        public string direccionentrega { get; set; }
        public int id_cliente { get; set; }
        public int id_estado { get; set; }
    }
}
