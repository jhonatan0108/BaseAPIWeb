﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ProductoContract
    {
        public Int32 idProducto { get; set; }
        public string descripcion { get; set; }
        public decimal stock { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Estado { get; set; }
        public string Imagen { get; set; }
    }
}
