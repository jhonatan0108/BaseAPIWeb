
using System;

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class FacturaContract
    {
        public string num_factura {  get; set; }
        public int cedula_cliente { get; set; }
        public DateTime fecha_factura { get; set; }
        public int cod_estado_factura { get; set; }
    }
}
