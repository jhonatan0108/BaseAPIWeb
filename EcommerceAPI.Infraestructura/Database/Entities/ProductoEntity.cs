using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("tblProductos")]
    public class ProductoEntity
    {
        [Key]
        public Int32 idProducto {  get; set; }
        public string descripcion { get; set; }
        public decimal stock { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Estado { get; set; } 
        public string Imagen { get; set; }
    }
}
