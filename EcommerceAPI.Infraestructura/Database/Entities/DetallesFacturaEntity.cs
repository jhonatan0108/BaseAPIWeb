using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("DetalleFactura")]
    public class DetallesFacturaEntity
    {
        [Key]
        public int id_detalle_factura {  get; set; }
        public int id_factura { get; set; }
        public int id_producto { get; set; }
        public double valor_compra_unidad { get; set; }
        public decimal cantidad { get; set; }
    }
}
