﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities
{
    [Table("tbl_det_factura")]
    public class DetFacturaEntity
    {
        [Key]
        //public int cod_item {  get; set; }
        public string num_factura { get; set; }
        public string cod_producto { get; set; }
        public decimal cantidad { get; set; }
        public decimal vlr_venta_producto { get; set; }
    }
}
