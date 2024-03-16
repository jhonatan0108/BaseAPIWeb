using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ProductoContract
    {

        public int id_producto { get; set; }
        public string imagen { get; set; }
        public int id_stock { get; set; }
        public decimal valor { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
    }
}
