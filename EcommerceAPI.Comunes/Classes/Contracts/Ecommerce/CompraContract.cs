using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class CompraContract
    {

        public int id_compra { get; set; }
        public DateTime fecha { get; set; }
        public string direccion_entrega { get; set; }
        public int id_estado { get; set; }
        public decimal valor_total { get; set; }
        public int id_cliente {  get; set; }

        public List<DetalleCompraContract> detalles { get; set; } = new List<DetalleCompraContract>();
    }
}
