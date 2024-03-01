using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("cliente")]
    public class ClienteEntity
    {
        [Key]
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
    }
}
