namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class DetalleFacturaContract
    {
        public int id_detalle_factura { get; set; }
        public int id_factura { get; set; }
        public int id_producto { get; set; }
        public double valor_compra_unidad { get; set; }
        public decimal cantidad { get; set; }
    }
}
