

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class CompraContract
    {
        public int id_compra { get; set; }
        public DateTime fecha { get; set; }
        public string valor_total { get; set; }
        public string direccion_entrega { get; set; }
        public int id_cliente { get; set; }
        public int id_estado { get; set; }
        public object Id { get; set; }
    }
}
