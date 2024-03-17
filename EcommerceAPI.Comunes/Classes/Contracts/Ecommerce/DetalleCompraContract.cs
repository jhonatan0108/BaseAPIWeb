using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class DetalleCompraContract
    {
        public int idDetalle {  get; set; }
        public int IdProducto { get; set; }
        public Int32 cantidad { get; set; }
        public decimal valorunitario  { get; set; }
        
    }
}
