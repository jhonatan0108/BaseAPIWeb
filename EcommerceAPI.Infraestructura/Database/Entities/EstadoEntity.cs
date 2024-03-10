using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("estado")]
    public class EstadoEntity
    {
        [Key]
        public int id_estado { get; set; }
        public string descripcion { get; set; }
        public string esquema { get; set; }
    }
}
