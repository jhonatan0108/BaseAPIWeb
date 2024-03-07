
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("tbl_factura")]
    public class FacturaEntity
    {
        [Key]
        public string num_factura { get; set; }
        public int cedula_cliente { get; set; }
        public DateTime fecha_factura { get; set; }
        public int cod_estado_factura { get; set; }
    }
}
