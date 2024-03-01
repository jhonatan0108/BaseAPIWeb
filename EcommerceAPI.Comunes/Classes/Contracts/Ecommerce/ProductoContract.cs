
namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
   public class ProductoContract
    {
        public string cod_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public decimal vlr_costo_producto { get; set; }
        public decimal vlr_venta_producto { get; set; }
        public decimal cantidad_producto_stock { get; set; }
        public int cod_estado { get; set; }
    }
}
