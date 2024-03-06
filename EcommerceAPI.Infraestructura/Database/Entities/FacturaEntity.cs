using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("Factura")]
    public class FacturaEntity
    {
        [Key]
        public int id_factura {  get; set; }
        public int cliente_cedula { get; set; }

        public DateTime fecha_compra {  get; set; }

        public string direccion_envio { get; set; }
        public double? valor_total { get; set; }
        public int estado_compra { get; set; }  
    }
}
