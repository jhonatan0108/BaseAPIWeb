using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("producto")]
    public class ProductoEntity
    {
        [Key]
        public int id_producto { get; set; }
        public string descripcion { get; set; }
        public double valor { get; set; }
        public string imagen { get; set; }
        public int id_estado { get; set; }
        public int stock { get; set; }
    }
}
