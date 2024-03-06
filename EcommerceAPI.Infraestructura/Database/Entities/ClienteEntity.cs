

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("Cliente")]
    public class ClienteEntity
    {
        [Key]
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string Password { get; set; }
        public string correo { get; set; }
        public string direccioncliente { get; set; }
        public decimal telefono { get; set; }
        public int Consecutivo { get; set; }

    }
}
