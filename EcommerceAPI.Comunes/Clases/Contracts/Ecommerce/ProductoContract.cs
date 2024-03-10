using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Clases.Contracts.Ecommerce
{
    public class ProductoContract
    {
        public int id_producto { get; set; }
        public string descripcion { get; set; }
        public double valor { get; set; }
        public string imagen { get; set; }
        public int id_estado { get; set; }
        public int stock  { get; set; }
    }
}
