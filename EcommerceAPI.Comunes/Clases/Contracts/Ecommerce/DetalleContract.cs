using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Clases.Contracts.Ecommerce
{
    public class DetalleContract
    {

        public int id_detallecompra { get; set; }
        public int cantidad { get; set; }
        public double valorunitario  { get; set; }
        public int id_compra { get; set; }
        public int id_producto { get; set; }
      
    }
}
