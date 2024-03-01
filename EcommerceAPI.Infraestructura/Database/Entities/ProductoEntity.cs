using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("tblProductos")]
    public class ProductoEntity
    {
        [Key]
        public int idProducto {  get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Estado { get; set; } 
        public string Imagen { get; set; }
    }
}
