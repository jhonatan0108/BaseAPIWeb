using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("tbl_cliente")]
    public class ClienteEntity
    {
        [Key]
        public int cedula_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string contrasena_cliente { get; set; }
        public string correo_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public decimal telefono_cliente { get; set; }
    }
}
