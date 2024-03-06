

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("DetalleCompra")]
    public class DetalleCompraEntity
    {
        [Key]
        public int id_detallecompra { get; set; }
        public int cantidad { get; set; }
        public float voluntario { get; set; }
        public int id_compra { get; set; }
        public int id_producto { get; set; }
        public CompraEntity Compra { get; set; }
        public ProductoEntity Producto { get; set; }
    }
}
