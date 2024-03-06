
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("Producto")]
    public class ProductoEntity
    {
        [Key]
        public int id_Producto { get; set; }
        public string descripcion { get; set; }
        public double valor { get; set; }
        public string? imagen { get; set; }
        public int id_estado { get; set; }
        public int stock { get; set; }
    }
}
