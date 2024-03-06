using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("Producto")]
    public class ProductoEntity
    {
        [Key]
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion {  get; set; }
        public string imagen {  get; set; }
        public Double valor_unitario { get; set; }
        public decimal stock { get; set; }
        public int id_estado {  get; set; }

    }
}
