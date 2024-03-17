using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class DetalleCompraContract
    {
        public int idDetalle { get; set; }

        public int idCompra { get; set; }

        public int idProducto { get; set; }

        public ProductoContract? Producto { get; set; }

        public Int32 cantidad { get; set; }

        public decimal valorunitario { get; set; }

    }
}
