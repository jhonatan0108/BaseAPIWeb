using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("Cliente")]
    public class ClienteEntity
    {
        [Key]
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public decimal? telefono { get; set; }
        public string direccion { get; set; }
    }
}
