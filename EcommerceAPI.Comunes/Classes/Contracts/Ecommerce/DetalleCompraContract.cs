using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class DetalleCompraContract
    {
        public int id_detallecompra { get; set; }
        public int cantidad { get; set; }
        public float voluntario { get; set; }
       // public int id_compra { get; set; }
       // public int id_producto { get; set; }
        public CompraContract id_Compra { get; set; }
        public ProductoContract id_Producto { get; set; }
        public int Id { get; set; }
    }
}
