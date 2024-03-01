using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    public class ProductoEntity
    {
        [Key]
        public int id_producto {  get; set; }
        public string imagen { get; set; }
        public StockEntity id_stock { get; set; }
        public decimal valor { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
    }
}
