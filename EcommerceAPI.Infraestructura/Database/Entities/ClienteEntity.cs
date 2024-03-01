using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("Cliente")]
    public class ClienteEntity//esta clase se encarga de la abstraccion o encapsulación de los datos de la entidad
    {
        [Key]
        public int id_cliente { get; set; }

        public string? contrasena { get; set; }
        public string nombre { get; set; }
        public int cedula { get; set; }
        public string coorreo { get; set; }
        public string direccion{ get; set; }
        public decimal? telefono { get; set; }
    }
}
