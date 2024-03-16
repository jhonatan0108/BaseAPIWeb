using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("DetalleCompra")]
    public class DetalleCompraEntity
    {
        [Key]
        public int id_detalleCompra {  get; set; }  
        public int cantidad { get; set; }   
        public float valor_unitario { get; set; }
        public int id_compra { get; set; }
        public int id_producto { get; set; }
    }
}
