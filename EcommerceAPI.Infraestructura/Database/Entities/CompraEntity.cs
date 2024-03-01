using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("Compra")]
    public class CompraEntity
    {
        [Key]
        public int id_compra { get; set; }
        public DateTime fecha { get; set; }
        public string direccion_entrega { get; set; }

        public EstadoEntity id_estado { get; set; }  
        public decimal? valor_total { get; set; }
    }
}
