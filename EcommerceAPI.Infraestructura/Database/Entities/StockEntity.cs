using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    public class StockEntity
    {
        [Key]
        public int id_stock {  get; set; }
        public string estado { get; set; }
    }
}
