using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class CompraContract
    {
        public int idCompra { get; set; }
        public DateTime fecha { get; set; }
        public string dirEntrega { get; set; }
        public int Estado { get; set; }
        public decimal idCliente { get; set; }
        public decimal valor_total { get; set; }
        public List<DetalleCompraContract> detalles { get; set; } = new List<DetalleCompraContract>();

    }
}
