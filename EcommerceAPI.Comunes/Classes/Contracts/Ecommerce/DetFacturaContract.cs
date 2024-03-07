
namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class DetFacturaContract
    {
        //public int cod_item {  get; set; }
        public string num_factura { get; set; }
        public string cod_producto { get; set; }
        public decimal cantidad { get; set; }
        public decimal vlr_venta_producto { get; set; }

    }
}
