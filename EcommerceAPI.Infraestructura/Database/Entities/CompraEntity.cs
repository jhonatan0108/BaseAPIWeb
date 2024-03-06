using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("Compra")]
    public class CompraEntity
    {
        [Key]
        public int id_compra { get; set; }
        public DateTime fecha { get; set; }
        public double valor_total { get; set; }
        public string direccion_entrega { get; set; }
        public int id_cliente { get; set; }
        public int id_estado { get; set; }

    }
}
