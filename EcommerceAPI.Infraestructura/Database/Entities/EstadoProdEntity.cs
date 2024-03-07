
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{

    [Table("tbl_estado_producto")]
    public class EstadoProdEntity
    {
        [Key]
        //public int cod_estado { get; set; }
        public string valor_estado { get; set; }
        public string nombre_estado { get; set; }

    }
}
