using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("TblCompras")]
    public class CompraEntity
    {
        [Key]
        public int idCompra { get; set; }
        public string fecha { get; set; }
        public string dirEntrega { get; set; }
        public int Estado { get; set; }
        public decimal idCliente { get; set; }
    }
}
