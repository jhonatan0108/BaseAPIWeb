using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.DetalleCompra
{
    public interface IDetalleService
    {
        List<DetalleContract> ObtenerDetalleCompras();
        DetalleContract ObtenerDetalleCompra(int id_detallecompra);
        DetalleContract Crear(DetalleContract contract);
        DetalleContract Update(DetalleContract contract);
        bool Delete(int id_detallecompra);
    }
}
