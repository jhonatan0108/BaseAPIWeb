using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("TblClientes")]
    public class ClienteEntity
    {
        [Key]
        public decimal cedula { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public decimal telefono { get; set; }
    }
}
